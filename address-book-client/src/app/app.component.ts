import { Component } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { ContactsService } from '../services/contacts.service';
import { Contact } from '../models/contact';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  providers: [ContactsService],
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Address book';
  contactsService: ContactsService;
  contacts: Contact[];

  //pagination
  paginationPage: number = 1;

  constructor(contactsService: ContactsService){
    this.contactsService = contactsService;
  }

  contactSearchForm = new FormGroup({
    contactNameInput: new FormControl('')
  })

  ngOnInit(){
    this.getHeroes();
  }

  onSubmit(){
    // console.log(this.contactSearchForm.value.contactNameInput);
    // this.getHeroes();
  }

  getHeroes(): void {
    this.contactsService.getContacts().subscribe(response => {
      this.contacts = response;
      console.log(this.contacts);
    });
  }
}
