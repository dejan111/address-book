import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { FormGroup, FormControl } from '@angular/forms';
import { ContactsService } from '../../services/contacts.service';
import { Contact } from '../../models/contact';

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

  constructor(private router: Router, contactsService: ContactsService){
    this.contactsService = contactsService;
  }

  contactSearchForm = new FormGroup({
    contactNameInput: new FormControl('')
  })

  ngOnInit(){
    this.getContacts();
  }

  onSubmit(){
    // console.log(this.contactSearchForm.value.contactNameInput);
    // this.getHeroes();
  }

  getContacts(): void {
    this.contactsService.getContacts().subscribe(response => {
      this.contacts = response;
      console.log(this.contacts);
    });
  }

  goToPage(pageName: string):void{
    console.log('eto me klikčem')
    let result = this.router.navigate([`${pageName}`]);
    console.log(result);
  }
}
