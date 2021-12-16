import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable, throwError } from 'rxjs'
import { catchError, retry } from 'rxjs/operators'
import { Events } from "../models/Events";
@Injectable({
    providedIn: 'root',
}

)
export class EventsApiService {
    constructor(
        private httpClient: HttpClient

    ) { }

    
    

    
    getArticle(): Observable<Events[]> {
        return this.httpClient.get<Events[]>("https://localhost:44347/events/list")
    }
    // createArticle(request: CreateARticleRequest): Observable<Article> {
    //     return this.httpClient.post<Article>("https://localhost:44328/Articles/new/", request)
    // }
}