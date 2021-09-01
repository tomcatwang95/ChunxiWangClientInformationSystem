import { Component, OnInit } from '@angular/core';
import { JwtHelperService } from '@auth0/angular-jwt';
import { AuthService } from '../Core/Service/auth.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  isLoggedIn:Boolean=false;
  user!: string;
  private jwtHelper=new JwtHelperService();

  constructor(private authService:AuthService) { }

  ngOnInit(): void {
    this.authService.isLoggedin.subscribe(resp=>this.isLoggedIn=resp);
  }

}
