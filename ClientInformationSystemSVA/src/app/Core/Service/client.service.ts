import { Injectable } from '@angular/core';
import { ClientList } from 'src/app/Shared/Models/ClientList';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import {Client} from 'src/app/Shared/Models/Client';
import { Observable } from 'rxjs';
import {map} from 'rxjs/operators'
import {environment} from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ClientService {

  constructor(private http: HttpClient) { }
  getclientlist():Observable<ClientList[]>{
    return this.http.get(`${environment.apiurl}${'Client/listall'}`)
    .pipe(
      map(resp => resp as ClientList[])
    )
  }
  createclient(Client:Client):Observable<Client>{
    return this.http.post<Client>(`${environment.apiurl}${'Client/create'}`,Client).pipe(map(resp=>resp as Client));  
  }
  updateclient(Client:Client):Observable<Client>{
    return this.http.put<Client>(`${environment.apiurl}${'Client/update'}`,Client).pipe(map(resp=>resp as Client));  
  } 
  deleteclient(id:number):Observable<Client>{
    return this.http.delete<Client>(`${environment.apiurl}${'Client/'}${id}${'/delete'}`).pipe(map(resp=>resp as Client));
  } 
    
}
