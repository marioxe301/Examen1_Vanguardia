import { Component, OnInit } from '@angular/core';
import {Account} from '../../models/account';
import { AccountService  } from '../../services/account.service';

@Component({
  selector: 'app-accounts',
  templateUrl: './accounts.component.html',
  styleUrls: ['./accounts.component.css']
})

export class AccountsComponent implements OnInit {

  accounts: Account[];
  accountService: AccountService;

  constructor() { }
  
  ngOnInit(): void {
    this.accountService.getAccounts().subscribe(
      (accounts: Account[]) => this.accounts = accounts
    )
  }

}
