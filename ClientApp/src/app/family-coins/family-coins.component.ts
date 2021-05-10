import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-family-coins',
  templateUrl: './family-coins.component.html'
})
export class FamilyCoinsComponent {
  public members: Member[];
  public transactions: Transaction[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Member[]>(baseUrl + 'members').subscribe(result => {
      this.members = result;
    }, error => console.error(error));
    http.get<Transaction[]>(baseUrl + 'transactions').subscribe(result => {
        this.transactions = result;
      }, error => console.error(error));
  }
}

interface Member {
  id: number;
  name: String;
  details: String;
  familyCoinsScore: number;
}

interface Transaction {
    id: number;
    name: String;
    typeOfTransaction: TypeOfTransaction;
    details: String;
    points: number;
  }

  enum TypeOfTransaction{

        PURCHASE = 1,
        FAMILYACTIVITY = 0,
  }
