import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { InteractionService } from 'src/app/Core/Service/interaction.service';
import { Interaction } from 'src/app/Shared/Models/Interaction';

@Component({
  selector: 'app-addinteraction',
  templateUrl: './addinteraction.component.html',
  styleUrls: ['./addinteraction.component.css']
})
export class AddinteractionComponent implements OnInit {

  constructor(private interactionservice:InteractionService) { }
  addinteraction:Interaction={
    clientId:'',
    empId:'',
    intType:'',
    intDate:new Date(),
    remarks:''
  }

  Addsuccess!:Boolean;


  ngOnInit(): void {
    
  }
  createinteraction(f:NgForm)
  {
    this.interactionservice.createinteraction(this.addinteraction).subscribe(
      (resp)=>{ if (resp){this.Addsuccess=true;}
      }
    );
  }

}
