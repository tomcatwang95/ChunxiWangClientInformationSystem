import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ClientService } from 'src/app/Core/Service/client.service';

@Component({
  selector: 'app-deleteclient',
  templateUrl: './deleteclient.component.html',
  styleUrls: ['./deleteclient.component.css']
})
export class DeleteclientComponent implements OnInit {

  constructor(private clientservice:ClientService) { }
  Deletesuccess!:Boolean;
  id!: number;
  ngOnInit(): void {
    
  }
  deleteclient(f:NgForm)
  {
    this.clientservice.deleteclient(this.id).subscribe(
      (resp)=>{ if (resp){this.Deletesuccess=true;}
      }
    );
  }


}
