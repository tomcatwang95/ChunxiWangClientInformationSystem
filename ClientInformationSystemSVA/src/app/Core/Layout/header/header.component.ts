import { getMissingNgModuleMetadataErrorData } from '@angular/compiler';
import { Component, OnInit } from '@angular/core';
import { JwtHelperService } from '@auth0/angular-jwt';
import { AuthService } from '../../Service/auth.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {

  isLoggedIn:Boolean=false;
  user!: string;
  private jwtHelper=new JwtHelperService();

  constructor(private authService:AuthService) { 
  }

  ngOnInit(): void {
    this.authService.isLoggedin.subscribe(resp=>this.isLoggedIn=resp);
    this.user=this.authService.getTokenInfo();
   
  }
  

}
