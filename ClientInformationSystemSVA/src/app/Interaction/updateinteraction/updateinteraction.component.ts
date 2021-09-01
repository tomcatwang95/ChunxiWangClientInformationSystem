import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { InteractionService } from 'src/app/Core/Service/interaction.service';
import { Interaction } from 'src/app/Shared/Models/Interaction';

@Component({
  selector: 'app-updateinteraction',
  templateUrl: './updateinteraction.component.html',
  styleUrls: ['./updateinteraction.component.css']
})
export class UpdateinteractionComponent implements OnInit {

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
  updateinteraction(f:NgForm)
  {
    this.interactionservice.updateinteraction(this.addinteraction).subscribe(
      (resp)=>{ if (resp){this.Addsuccess=true;}
      }
    );
  }


}


