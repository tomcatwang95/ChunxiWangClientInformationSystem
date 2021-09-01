import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { InteractionService } from 'src/app/Core/Service/interaction.service';

@Component({
  selector: 'app-deleteinteraction',
  templateUrl: './deleteinteraction.component.html',
  styleUrls: ['./deleteinteraction.component.css']
})
export class DeleteinteractionComponent implements OnInit {

  constructor(private interactionservice:InteractionService) { }
  Deletesuccess!:Boolean;
  id!: number;
  ngOnInit(): void {
    
  }
  deleteinteraction(f:NgForm)
  {
    this.interactionservice.deleteinteraction(this.id).subscribe(
      (resp)=>{ if (resp){this.Deletesuccess=true;}
      }
    );
  }
}
