import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EventListComponent } from './events/event-list/event-list.component';
import { NewEventComponent } from './events/new-event/new-event.component';
import { SingleEventComponent } from './events/single-event/single-event.component';

const routes: Routes = [
   { path: "home", component: EventListComponent},
   { path:"events/:id", component: SingleEventComponent },
   { path: "new", component: NewEventComponent},


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
