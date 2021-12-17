import { Component, Input, OnInit } from '@angular/core';
import { Router } from  '@angular/router';
import { Events } from '../../models/Events';

@Component({
  selector: 'app-event-previews',
  templateUrl: './event-previews.component.html',
  styleUrls: ['./event-previews.component.css']
})
export class EventPreviewsComponent implements OnInit {

  @Input() content!: Events;

  constructor(
    private router: Router,
  ) { }

  ngOnInit(): void {
  }

}
