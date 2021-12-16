import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SingleEventComponent } from './single-event/single-event.component';
import { EventPreviewsComponent } from './event-previews/event-previews.component';
import { EventListComponent } from './event-list/event-list.component';



@NgModule({
  declarations: [
    SingleEventComponent,
    EventPreviewsComponent,
    EventListComponent
  ],  
  imports: [
    CommonModule
  ]
})
export class EventsModule { }
