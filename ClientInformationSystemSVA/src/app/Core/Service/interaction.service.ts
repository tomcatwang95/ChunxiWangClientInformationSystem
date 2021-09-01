import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { EmployeeList } from 'src/app/Shared/Models/EmployeeList';
import { InteractionList } from 'src/app/Shared/Models/InteractionList';
import { environment } from 'src/environments/environment';
import {map} from 'rxjs/operators'
import { Interaction } from 'src/app/Shared/Models/Interaction';

@Injectable({
  providedIn: 'root'
})
export class InteractionService {

  constructor(private http: HttpClient) { }
  getinteractionlist():Observable<InteractionList[]>{
    return this.http.get(`${environment.apiurl}` + 'Interaction/listall')
    .pipe(
      map(resp => resp as InteractionList[])
    )
  }
  createinteraction(interaction:Interaction):Observable<Interaction>{
    return this.http.post<Interaction>(`${environment.apiurl}${'Interaction/create'}`,interaction).pipe(map(resp=>resp as Interaction));  
  }
  updateinteraction(interaction:Interaction):Observable<Interaction>{
    return this.http.put<Interaction>(`${environment.apiurl}${'Interaction/update'}`,interaction).pipe(map(resp=>resp as Interaction));  
  } 
  deleteinteraction(id:number):Observable<Interaction>{
    return this.http.delete<Interaction>(`${environment.apiurl}${'Interaction/'}${id}${'/delete'}`).pipe(map(resp=>resp as Interaction));
  } 
}
