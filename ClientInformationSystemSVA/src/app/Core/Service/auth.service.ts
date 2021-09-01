import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { JwtHelperService } from '@auth0/angular-jwt';
import { BehaviorSubject, Observable } from 'rxjs';
import { map } from 'rxjs/internal/operators/map';
import { Employee } from 'src/app/Shared/Models/Employee';
import {Login} from 'src/app/Shared/Models/Login'
import { environment } from 'src/environments/environment';


@Injectable({
  providedIn: 'root'
})
export class AuthService {  
  private currentEmployeeSubject=new BehaviorSubject<Employee>({} as Employee);
  public currentEmployee=this.currentEmployeeSubject.asObservable();

  private isLoggedinSubject= new BehaviorSubject<boolean>(false);
  public isLoggedin=this.isLoggedinSubject.asObservable();

  private jwtHelper=new JwtHelperService();
  name!: string;

  constructor(private http: HttpClient) {
    
  }

  login(login: Login): Observable<Boolean>{
   return this.http.post(`${environment.apiurl}`+'Account/login', login)
   .pipe(
     map( (response:any) => {
       if (response){
         localStorage.setItem("token", response.token)
         //take the response and save the token in localstorage
         this.populateEmployeeInfo();
         
         return true;
       }
       return false;
     })
     )
    //call api: account/login
    //HTTP POST
    //JWT if it is valid; save the token in local storage
    
  }
  populateEmployeeInfo()
  {
    var token=localStorage.getItem('token');
    if (token && !this.jwtHelper.isTokenExpired(token))
    {//decode the token
        const decodedToken=this.jwtHelper.decodeToken(token);
        console.log(decodedToken);
        //set current employee into observable
        this.currentEmployeeSubject.next(decodedToken);
        this.isLoggedinSubject.next(true);
    }
  }
  getTokenInfo():string
  {
    var token=localStorage.getItem('token');
    var user;
    if (token && !this.jwtHelper.isTokenExpired(token))
    {//decode the token
        const decodedToken=this.jwtHelper.decodeToken(token);
        user=decodedToken.unique_name;
    }
    return user;
  }
  logout(){
    //delete the token from local storage
      localStorage.removeItem('token');

      //clear out the observable
      this.currentEmployeeSubject.next({} as Employee);
      this.isLoggedinSubject.next(false);
  }
}
