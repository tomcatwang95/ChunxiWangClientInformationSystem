import { Component, OnInit } from '@angular/core';
import { InteractionService } from 'src/app/Core/Service/interaction.service';
import { InteractionList } from 'src/app/Shared/Models/InteractionList';

@Component({
  selector: 'app-interactionprofile',
  templateUrl: './interactionprofile.component.html',
  styleUrls: ['./interactionprofile.component.css']
})
export class InteractionprofileComponent implements OnInit {
  
  interactions!:InteractionList[];

  constructor(private interactionservice:InteractionService) { }

  ngOnInit(): void {
    this.interactionservice.getinteractionlist().subscribe(
      e=>{
        this.interactions=e;
        console.log('Inside this home component init method');
        console.table(this.interactions); 
      }
    );
  }

}
