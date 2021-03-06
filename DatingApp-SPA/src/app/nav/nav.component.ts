import { Component, OnInit } from '@angular/core';
import { AuthService } from '../_services/auth.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
model: any = {};
  constructor(private authService: AuthService) { }

  ngOnInit() {
  }
  // SUbscribe is the action to take when we received the data
  login() {
   this.authService.login(this.model).subscribe(next => {

    console.log('Logged in successfully');

   }, error => {
     console.log(error);
   });
  }
  loggedIn() {

    const token = localStorage.getItem('token');
    // if is empty return false else return true
    return !!token;
  }
  logout() {
localStorage.removeItem('token');
console.log('logged out');

  }

}
