import { Component, NgModule, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ClientService } from 'src/app/Core/Service/client.service';
import { Client } from 'src/app/Shared/Models/Client';

@Component({
  selector: 'app-updateclient',
  templateUrl: './updateclient.component.html',
  styleUrls: ['./updateclient.component.css']
})
export class UpdateclientComponent implements OnInit {

  constructor(private clientservice:ClientService) { }
  addclient:Client={
    name:'',
    email:'',
    phones:'',
    address:'',
    addedOn:new Date()
  }
  Updatesuccess!:Boolean;

  ngOnInit(): void {
  }
  updateclient(f:NgForm)
  {
    this.clientservice.updateclient(this.addclient).subscribe(
      (resp)=>{ if (resp){this.Updatesuccess=true;}
      }
    );
  }

}
