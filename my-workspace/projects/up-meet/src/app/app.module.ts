import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EventListComponent } from './events/event-list/event-list.component';
import { EventsModule } from './events/events.module';

@NgModule({
  declarations: [
    AppComponent
    // EventListComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    EventsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
