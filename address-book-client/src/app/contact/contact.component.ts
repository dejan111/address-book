import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { Contact } from 'src/models/contact';
import { ContactsService } from '../../services/contacts.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  providers: [ContactsService],
  styleUrls: ['./contact.component.css']
})
export class ContactComponent implements OnInit {
  contactsService: ContactsService;
  contact: Contact = <Contact> { address: {}, phoneNum: [] };

  maxDate : Date;

  contactForm = new FormGroup({
    nameInput: new FormControl(''),
    phoneNumInput: new FormControl(''),
    addressInput: new FormControl(''),
    cityInput: new FormControl(''),
    countryInput: new FormControl(''),
    zipCodeInput: new FormControl(''),
    dateOfBirthInput: new FormControl('')
  })

  constructor(private router: Router, contactsService: ContactsService) { 
    this.contactsService = contactsService;
  }

  ngOnInit(): void {
    this.maxDate = this.getYesterday();
  }

  onSubmit(){
      this.contact.name = this.contactForm.value.nameInput;
      this.contact.phoneNum.push(this.contactForm.value.phoneNumInput);
      this.contact.address.address = this.contactForm.value.addressInput;
      this.contact.address.city = this.contactForm.value.cityInput;
      this.contact.address.country = this.contactForm.value.countryInput;
      this.contact.address.zipCode = this.contactForm.value.zipCodeInput;
      this.contact.dateOfBirth = this.contactForm.value.dateOfBirthInput;
      
      this.addContact(this.contact);

      let result = this.router.navigate(['AddressBook']);
      console.log(result);
  }

  addContact(contact: Contact): void {
    this.contactsService.addContact(contact).subscribe();
  }

  getYesterday() {
    let maxDate = new Date();
    maxDate.setDate(maxDate.getDate() - 1);

    return maxDate;
  }
}
