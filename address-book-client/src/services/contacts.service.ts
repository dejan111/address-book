import { Injectable } from '@angular/core';
import { HttpHeaders, HttpClient, HttpResponse, HttpParams } from '@angular/common/http';

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

    getContacts(name: string): Observable<Contact[]> {
      name = name.trim();

      const searchOptionsHttp = name ?
      { params: new HttpParams().set('name', name)} : {};
      return this.http.get<Contact[]>(this.addressBookUrl, searchOptionsHttp);
    }

    addContact(contact: Contact): Observable<Contact>{
        return this.http.post<Contact>(this.addContactUrl, contact, httpOptions);
    }
}