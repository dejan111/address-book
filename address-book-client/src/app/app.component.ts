import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  clicked: boolean = false;
  constructor(private router: Router){

  }

  goToPage(pageName: string):void{
    this.clicked = true;
    this.router.navigate([`${pageName}`]);
  }
}
