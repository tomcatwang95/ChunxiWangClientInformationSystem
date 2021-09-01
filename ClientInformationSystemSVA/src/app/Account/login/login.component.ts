import { CompileShallowModuleMetadata } from '@angular/compiler';
import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { AuthService } from 'src/app/Core/Service/auth.service';
import {Login} from 'src/app/Shared/Models/Login'

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  login: Login = {
    name:'',
    password:''
  };
  InvalidLogin!: Boolean;

  constructor(private authService: AuthService, private router: Router, private currentRoute: ActivatedRoute)  { }

  ngOnInit(): void {
    console.log("inside ngonit Login Component");
    console.log(this.login);
  }
  loginsubmit(f:NgForm){
    console.log("Submit buttom clicked.");
    //console.log(this.login);
    this.authService.login(this.login).subscribe(
      (response)=>{
        if (response){
          //go to home page
          this.router.navigate(['/']);
        }
        else{
          this.InvalidLogin=true;
        }
      }, (err:any)=>{this.InvalidLogin=true, console.log(err);}
    );
    //send this object to a service
  }
  

}

