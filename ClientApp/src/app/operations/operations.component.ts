import { Component, OnInit } from '@angular/core';
import { Operation } from '../models/Operation';
import { OperationType } from '../models/OperationType';
import { Person } from '../models/Person';
import { OperationService } from '../services/operation.service';
import { PersonService } from '../services/person.service';

@Component({
  selector: 'app-operations',
  templateUrl: './operations.component.html',
  styleUrls: ['./operations.component.css']
})
export class OperationsComponent implements OnInit {
  operations: Operation[];

  personsFrom: Person[];
  operationTypes: OperationType[];
  personsTo: Person[];

  personFromId: number;
  operationTypeId: number;
  amount: number;
  personToId: number;

  constructor(private operationService: OperationService, private personService: PersonService) {
    this.personFromId = this.operationTypeId = this.personToId = -1;
  }

  ngOnInit() {
    this.getOperations();

    this.personService.getPersons().subscribe(persons => {
      this.personsTo = this.personsFrom = persons;
    }, error => console.error(error));

    this.operationService.getOperationTypes().subscribe(operationTypes => {
      this.operationTypes = operationTypes;
    }, error => console.error(error));
  }

  getOperations() {
    this.operationService.getOperations().subscribe(operations => {
      this.operations = operations;
    }, error => console.error(error));
  }

  onSubmit() {
    const operation = {
      personFromId: this.personFromId,
      operationTypeId: this.operationTypeId,
      amount: this.amount,
      personToId: this.personToId
    }
    this.operationService.postOperation(operation).subscribe(_ => this.getOperations());
  }
}
