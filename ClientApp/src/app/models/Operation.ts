export class Operation {
    id: number;
    operationTypeName: string;
    amount: number;
    personFromFullName: string;
    personToFullName: string;
}

export class OperationPostDto {
    operationTypeId: number;
    amount: number;
    personFromId: number;
    personToId: number;
}