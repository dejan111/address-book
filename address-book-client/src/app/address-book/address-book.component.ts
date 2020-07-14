import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router, Data } from '@angular/router';
import { FormGroup, FormControl } from '@angular/forms';
import { ContactsService } from '../../services/contacts.service';
import { Contact } from '../../models/contact';
import { DataService } from '../../models/dataService';

@Component({
  selector: 'app-address-book',
  templateUrl: './address-book.component.html',
  providers: [ContactsService],
  styleUrls: ['./address-book.component.css']
})
export class AddressBookComponent implements OnInit {
  title = 'Address book';
  contactsService: ContactsService;
  contacts: Contact[];

  //pagination
  paginationPage: number = 1;

  constructor(private router: Router, contactsService: ContactsService, public dataService: DataService){
    this.contactsService = contactsService;
  }

  ngOnInit(){
    this.getContacts('');
  }

  getContacts(name: string): void {
    this.paginationPage = 1;
    this.contactsService.getContacts(name).subscribe(response => {
      this.contacts = response;
      console.log(this.contacts);
    });
  }

  goToPage(pageName: string):void{
    console.log('add contact click');
    let result = this.router.navigate([`${pageName}`]);
    console.log(result);
  }

  delete(id: number): void{
    this.paginationPage = 1;
    this.contactsService.deleteContact(id).subscribe(() => {
      this.getContacts('');
    });
  }

  editContact(contact: Contact){
    this.dataService.contact = contact;
    this.router.navigate(['Contact']);
  }
}
