import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { DataService } from '../models/dataService';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  providers: [DataService],
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  clicked: boolean = false;
  constructor(private router: Router){
    router.navigate(['/AddressBook']);
  }

  goToPage(pageName: string):void{
    this.clicked = true;
    this.router.navigate([`${pageName}`]);
  }
}
