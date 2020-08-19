import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {Observable} from 'rxjs';
import { Transaction } from '../models/transaction';

@Injectable({
  providedIn: 'root'
})
export class TransactionService {

  Url: string = "https://localhost:44343/api/transaction";

  constructor(private httpClient: HttpClient) { }

  getTransactions(): Observable<Transaction[]>{
    return this.httpClient.get<Transaction[]>(this.Url);
  }

  makeTransaction(transaction: Transaction): Observable<Transaction>{
    return this.httpClient.post<Transaction>(this.Url,transaction);
  }
}
