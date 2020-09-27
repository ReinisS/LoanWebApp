import { Person } from "./Person";

export class PersonDetails extends Person {
    amountLoanedToOthers: number;
    amountLoanedFromOthers: number;
    total: number;
}