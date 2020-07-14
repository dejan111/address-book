import { Injectable } from '@angular/core';
import { HttpHeaders, HttpClient, HttpResponse, HttpParams } from '@angular/common/http';

import { Observable } from 'rxjs';
//import { catchError } from 'rxjs/operators';

import { Contact } from '../models/contact';

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
    contactUrl = '/api/addressbook/contact';
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
      console.log('service.add');
      return this.http.post<Contact>(this.contactUrl, contact, httpOptions);
    }

    deleteContact(id: number): Observable<{}> {
      const url = `${this.contactUrl}/${id}`;
      return this.http.delete(url, httpOptions);
    }

    updateContact(contact: Contact): Observable<Contact>{
      console.log('service.update');

      console.log(contact);

      const url = `${this.contactUrl}/${contact.id}`;
      return this.http.put<Contact>(url, contact, httpOptions);
  }
}