import { Injectable } from '@angular/core';
import { HttpHeaders, HttpClient, HttpResponse } from '@angular/common/http';

import { Observable } from 'rxjs';
//import { catchError } from 'rxjs/operators';

import { Contact } from '../models/contact';
//import { FlightRequest } from './flightRequest';

const httpOptions = {
    headers: new HttpHeaders({
      ContentType:  'application/json',
      observe: 'body',
      responseType: 'json'
      //'Authorization': 'my-auth-token'
    })
  };

@Injectable()
export class ContactsService{
    addressBookUrl = '/api/addressbook/';
    addContactUrl = '/api/addressbook/contact';
    addressBookResponse$: Observable<{}>;

    constructor(private http: HttpClient) {
    }

    getContacts(): Observable<Contact[]> {
        console.log('evo me tu');

        return this.http.get<Contact[]>(this.addressBookUrl, httpOptions);
    }

    addContact(contact: Contact): Observable<Contact>{
        return this.http.post<Contact>(this.addContactUrl, contact, httpOptions);
    }
}