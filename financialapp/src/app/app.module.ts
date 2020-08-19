import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { ServiceCoreModule } from './services/service-core.module';
import {AppRoutingModule} from './app-routing.module';
import { TransactionsComponent } from './components/transactions/transactions.component';
import {AccountModule} from './components/accounts/account.module';
import { TransactionModule} from './components/transactions/transaction.module';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    AccountModule,
    TransactionModule,
    ServiceCoreModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
