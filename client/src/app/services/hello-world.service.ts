import { Injectable } from '@angular/core';
import { environment } from '../../environment/environment.dev';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class HelloWorldService {
  readonly apiUrl = environment.apiUrl

  constructor(
    private _http: HttpClient
  ) { }

  getHelloWorld(): Observable<any>{
    return this._http.get(this.apiUrl + "/helloWorld")
  }
}
