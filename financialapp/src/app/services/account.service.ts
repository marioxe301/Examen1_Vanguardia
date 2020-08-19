import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {Observable} from 'rxjs';
import { Account } from '../models/account';

@Injectable({
  providedIn: 'root'
})
export class AccountService {

  Url: string = "https://localhost:44343/api/account";


  constructor(private httpClient: HttpClient) { }

  getAccounts(): Observable<Account[]>{
    return this.httpClient.get<Account[]>(this.Url)
  }
}
