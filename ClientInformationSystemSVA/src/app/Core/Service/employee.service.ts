import { Injectable } from '@angular/core';
import { EmployeeList } from 'src/app/Shared/Models/EmployeeList';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import {map} from 'rxjs/operators'
import {environment} from 'src/environments/environment';
import { Employee } from 'src/app/Shared/Models/Employee';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  constructor(private http: HttpClient) { }
  getemployeelist():Observable<EmployeeList[]>{
    return this.http.get(`${environment.apiurl}` + 'Employee/listall')
    .pipe(
      map(resp => resp as EmployeeList[])
    )
  }
  createemployee(Employee:Employee):Observable<Employee>{
    return this.http.post<Employee>(`${environment.apiurl}${'Client/create'}`,Employee).pipe(map(resp=>resp as Employee));  
  }
  updateemployee(Employee:Employee):Observable<Employee>{
    return this.http.put<Employee>(`${environment.apiurl}${'Client/update'}`,Employee).pipe(map(resp=>resp as Employee));  
  } 
  deleteclient(id:number):Observable<Employee>{
    return this.http.delete<Employee>(`${environment.apiurl}${'Client/'}${id}${'/delete'}`).pipe(map(resp=>resp as Employee));
  } 
}