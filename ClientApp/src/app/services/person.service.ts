import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';

import { Person } from '../models/Person';
import { PersonDetails } from '../models/PersonDetails';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json'
  })
}

@Injectable({
  providedIn: 'root'
})
export class PersonService {

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  // Get person details list from database
  getPersons(): Observable<PersonDetails[]> {
    return this.http.get<PersonDetails[]>(this.baseUrl + 'person');
  }

  // Save person data to database
  postPerson(person: Person): Observable<any> {
    return this.http.post<any>(this.baseUrl + 'person', person, httpOptions);
  }
}