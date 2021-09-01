import { Component, OnInit } from '@angular/core';
import { ClientService } from 'src/app/Core/Service/client.service';
import { ClientList } from 'src/app/Shared/Models/ClientList';

@Component({
  selector: 'app-clientprofile',
  templateUrl: './clientprofile.component.html',
  styleUrls: ['./clientprofile.component.css']
})
export class ClientprofileComponent implements OnInit {
  clients!:ClientList[];

  constructor(private clientservice:ClientService) { }

  ngOnInit(): void {
    this.clientservice.getclientlist().subscribe(
      c=>{
        this.clients=c;
        console.log('Inside this home component init method');
        console.table(this.clients); 
      }
    );
  }

}
