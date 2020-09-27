import { Component, OnInit } from '@angular/core';
import { Person } from '../models/Person';
import { PersonDetails } from '../models/PersonDetails';
import { PersonService } from '../services/person.service';

@Component({
  selector: 'app-persons',
  templateUrl: './persons.component.html',
  styleUrls: ['./persons.component.css']
})
export class PersonsComponent implements OnInit {
  persons: PersonDetails[];

  firstName: string;
  otherNames: string;
  lastName: string;

  personDetails: Person;

  constructor(private personService: PersonService) { }

  ngOnInit() {
    this.getPersons();
  }

  getPersons() {
    this.personService.getPersons().subscribe(persons => {
      this.persons = persons;
    }, error => console.error(error));
  }

  onSubmit() {
    const person = {
      id: 0,
      firstName: this.firstName,
      otherNames: this.otherNames,
      lastName: this.lastName
    }
    this.personService.postPerson(person).subscribe(_ => this.getPersons());
  }
}
