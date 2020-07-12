import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { Contact } from 'src/models/contact';
import { ContactsService } from '../../services/contacts.service';

@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  providers: [ContactsService],
  styleUrls: ['./contact.component.css']
})
export class ContactComponent implements OnInit {
  contactsService: ContactsService;
  contact: Contact = <Contact> { address: {}, phoneNum: [] };

  contactForm = new FormGroup({
    nameInput: new FormControl(''),
    phoneNumInput: new FormControl(''),
    addressInput: new FormControl(''),
    cityInput: new FormControl(''),
    countryInput: new FormControl(''),
    zipCodeInput: new FormControl('')
  })

  constructor(contactsService: ContactsService) { 
    this.contactsService = contactsService;
  }

  ngOnInit(): void {
  }

  onSubmit(){
      this.contact.name = this.contactForm.value.nameInput;
      this.contact.phoneNum.push(this.contactForm.value.phoneNumInput);
      this.contact.address.address = this.contactForm.value.addressInput;
      
      this.addContact(this.contact);
  }

  addContact(contact: Contact): void {
    this.contactsService.addContact(contact).subscribe();
  }
}
