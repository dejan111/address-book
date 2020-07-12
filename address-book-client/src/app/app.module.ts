import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { ReactiveFormsModule } from '@angular/forms';
import { NgxPaginationModule } from 'ngx-pagination';

import { AppRoutingModule } from './app-routing.module';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';

import { ContactsService } from '../services/contacts.service';
import { ContactComponent } from './contact/contact.component';
import { AddressBookComponent } from './address-book/address-book.component'

@NgModule({
  declarations: [
    AppComponent,
    ContactComponent,
    AddressBookComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    ReactiveFormsModule,
    NgxPaginationModule,
    RouterModule.forRoot ([
      { path: 'Contact', component: ContactComponent },
      { path: 'AddressBook', component: AddressBookComponent }
    ])
  ],
  providers: [
    ContactsService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
