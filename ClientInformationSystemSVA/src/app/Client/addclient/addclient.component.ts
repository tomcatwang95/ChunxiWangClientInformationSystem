import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { ClientService } from 'src/app/Core/Service/client.service';
import { Client } from 'src/app/Shared/Models/Client';

@Component({
  selector: 'app-addclient',
  templateUrl: './addclient.component.html',
  styleUrls: ['./addclient.component.css']
})
export class AddclientComponent implements OnInit {

  constructor(private clientservice:ClientService, private router:Router) { }
  addclient:Client={
    name:'',
    email:'',
    phones:'',
    address:'',
    addedOn:new Date()
  }

  Addsuccess!:Boolean;


  ngOnInit(): void {
    
  }
  createclient()
  {
    this.clientservice.createclient(this.addclient).subscribe(
      (resp)=>{ if (resp){this.Addsuccess=true;}
      }
    );
  }

}
