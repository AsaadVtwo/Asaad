import { Component, OnInit } from '@angular/core';
import { AuthService } from '../_services/auth.service';
import { AlterifyService } from '../_services/alterify.service';


@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  model: any = {};

  constructor(private authService: AuthService, private alertify: AlterifyService) { }

  ngOnInit() {}

  login() {
    this.authService.login(this.model).subscribe(data => {
      this.alertify.success('Logged in successfully');
    }, error => {
      this.alertify.error('Failed to login');
    });
  }

  logout() {
    this.authService.userToken = null;
    localStorage.removeItem('token');
    this.alertify.warning('Logged out');
  }

  loggedIn() {
     return this.authService.loggedIn();
  }

}
