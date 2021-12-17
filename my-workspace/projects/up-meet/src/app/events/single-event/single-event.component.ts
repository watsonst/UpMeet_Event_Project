import { Component, Input, OnInit } from '@angular/core';
import { Router, ActivatedRoute, ParamMap} from '@angular/router'
import { Events } from '../../models/Events';
import { EventsApiService } from '../../services/events-api.service';


@Component({
  selector: 'app-single-event',
  templateUrl: './single-event.component.html',
  styleUrls: ['./single-event.component.css']
})
export class SingleEventComponent implements OnInit {
  events?: Events ;
  @Input() event!: Events;
  titleId: Number = 0
  dateId?: String = "N/A"
  //titleId?: String = "N/A"
  
  

  constructor(
    private eventsAPISvc: EventsApiService,
    private route: ActivatedRoute,
    private router: Router
  ) { }

  ngOnInit(): void {
    const id = this.route.snapshot.paramMap.get('id');
    if(id) {
      this.titleId = Number(id);
    }
    // const date = this.route.snapshot.queryParamMap

    // if(date) {
    //   this.dateId = date;
    // }
    this.eventsAPISvc.getArticle().subscribe((events) => {
     for(var i = 0; i < events.length; i++)
     {if (events[i].eventID == this.titleId)
      {
        this.events = events[i]
      }

     }
     console.log(this.events?.title)
      
    })
  }
  goToEvents() {
    this.router.navigate(["home"])
  }
}

// public eventID: Number, 
// public title: String,
// public date: String,
// public location: String,
// public organization: String,
// public details: String