import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';

import { Operation, OperationPostDto } from '../models/Operation';
import { OperationType } from '../models/OperationType';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json'
  })
}

@Injectable({
  providedIn: 'root'
})
export class OperationService {

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  getOperations(): Observable<Operation[]> {
    return this.http.get<Operation[]>(this.baseUrl + 'operation');
  }

  postOperation(operation: OperationPostDto): Observable<any> {
    return this.http.post<any>(this.baseUrl + 'operation', operation, httpOptions);
  }

  getOperationTypes(): Observable<OperationType[]> {
    return this.http.get<OperationType[]>(this.baseUrl + 'operationType');
  }
}