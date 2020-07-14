import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { Contact } from '../../models/contact';
import { ContactsService } from '../../services/contacts.service';
import { DataService } from '../../models/dataService';
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
  addContactBtn: Boolean = true;

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

  constructor(private router: Router, contactsService: ContactsService, public dataService: DataService) { 
    this.contactsService = contactsService;
  }

  ngOnInit(): void {
    this.maxDate = this.getYesterday();

    if(this.dataService.contact != null){
      this.contact = this.dataService.contact;
      this.contactForm.patchValue({nameInput: this.contact.name});
      this.contactForm.patchValue({dateOfBirthInput: this.contact.dateOfBirth});
      this.contactForm.patchValue({phoneNumInput: this.contact.phoneNum});
      this.contactForm.patchValue({cityInput: this.contact.address.city});
      this.contactForm.patchValue({countryInput: this.contact.address.country});
      this.contactForm.patchValue({zipCodeInput: this.contact.address.zipCode});
      this.contactForm.patchValue({addressInput: this.contact.address.address});

      this.addContactBtn = false;
    };
  }

  // onSubmit(){
  //     console.log('submit');
  //     this.setContactInputs();
      
  //     this.addContact(this.contact);

  //     let result = this.router.navigate(['AddressBook']);
  //     console.log(result);
  // }

  addContact(): void {
    console.log('submit');
    this.setContactInputs();
    this.contactsService.addContact(this.contact).subscribe(() => {
      this.router.navigate(['AddressBook']);
    });
  }

  getYesterday() {
    let maxDate = new Date();
    maxDate.setDate(maxDate.getDate() - 1);

    return maxDate;
  }

  setContactInputs(){
    this.contact.name = this.contactForm.value.nameInput;
    this.contact.phoneNum.length = 0;
    this.contact.phoneNum.push(this.contactForm.value.phoneNumInput[0]);
    this.contact.address.address = this.contactForm.value.addressInput;
    this.contact.address.city = this.contactForm.value.cityInput;
    this.contact.address.country = this.contactForm.value.countryInput;
    this.contact.address.zipCode = this.contactForm.value.zipCodeInput;
    this.contact.dateOfBirth = this.contactForm.value.dateOfBirthInput;
  }

  updateContact(){
    console.log('update');

    this.setContactInputs();
    this.contactsService.updateContact(this.contact).subscribe(() =>{
      this.router.navigate(['AddressBook']);
    });
  }
}
