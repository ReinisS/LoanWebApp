using Microsoft.EntityFrameworkCore.Migrations;

namespace LoanWebApp.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OperationType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(maxLength: 100, nullable: false),
                    OtherNames = table.Column<string>(maxLength: 100, nullable: true),
                    LastName = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Operation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OperationTypeId = table.Column<int>(nullable: false),
                    Amount = table.Column<double>(nullable: false),
                    PersonFromId = table.Column<int>(nullable: false),
                    PersonToId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Operation_OperationType_OperationTypeId",
                        column: x => x.OperationTypeId,
                        principalTable: "OperationType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Operation_Person_PersonFromId",
                        column: x => x.PersonFromId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Operation_Person_PersonToId",
                        column: x => x.PersonToId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "OperationType",
                columns: new[] { "Id", "Name" },
                values: new object[] { 0, "Loan" });

            migrationBuilder.InsertData(
                table: "OperationType",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Repayment" });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "FirstName", "LastName", "OtherNames" },
                values: new object[] { 1, "Jānis", "Bērziņš", null });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "FirstName", "LastName", "OtherNames" },
                values: new object[] { 2, "Līga", "Ceriņa", null });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "FirstName", "LastName", "OtherNames" },
                values: new object[] { 3, "Andris", "Ozols", "Juris" });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "FirstName", "LastName", "OtherNames" },
                values: new object[] { 4, "Anna", "Vītola", "Marija" });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "FirstName", "LastName", "OtherNames" },
                values: new object[] { 5, "Pēteris", "Osis", null });

            migrationBuilder.InsertData(
                table: "Operation",
                columns: new[] { "Id", "Amount", "OperationTypeId", "PersonFromId", "PersonToId" },
                values: new object[] { 1, 1.0, 0, 1, 2 });

            migrationBuilder.InsertData(
                table: "Operation",
                columns: new[] { "Id", "Amount", "OperationTypeId", "PersonFromId", "PersonToId" },
                values: new object[] { 18, 5.0, 0, 4, 5 });

            migrationBuilder.InsertData(
                table: "Operation",
                columns: new[] { "Id", "Amount", "OperationTypeId", "PersonFromId", "PersonToId" },
                values: new object[] { 17, 5.0, 0, 4, 5 });

            migrationBuilder.InsertData(
                table: "Operation",
                columns: new[] { "Id", "Amount", "OperationTypeId", "PersonFromId", "PersonToId" },
                values: new object[] { 16, 5.0, 0, 4, 5 });

            migrationBuilder.InsertData(
                table: "Operation",
                columns: new[] { "Id", "Amount", "OperationTypeId", "PersonFromId", "PersonToId" },
                values: new object[] { 15, 5.0, 0, 4, 5 });

            migrationBuilder.InsertData(
                table: "Operation",
                columns: new[] { "Id", "Amount", "OperationTypeId", "PersonFromId", "PersonToId" },
                values: new object[] { 14, 5.0, 0, 4, 5 });

            migrationBuilder.InsertData(
                table: "Operation",
                columns: new[] { "Id", "Amount", "OperationTypeId", "PersonFromId", "PersonToId" },
                values: new object[] { 13, 5.0, 0, 4, 5 });

            migrationBuilder.InsertData(
                table: "Operation",
                columns: new[] { "Id", "Amount", "OperationTypeId", "PersonFromId", "PersonToId" },
                values: new object[] { 12, 5.0, 0, 4, 5 });

            migrationBuilder.InsertData(
                table: "Operation",
                columns: new[] { "Id", "Amount", "OperationTypeId", "PersonFromId", "PersonToId" },
                values: new object[] { 11, 5.0, 0, 4, 5 });

            migrationBuilder.InsertData(
                table: "Operation",
                columns: new[] { "Id", "Amount", "OperationTypeId", "PersonFromId", "PersonToId" },
                values: new object[] { 10, 5.0, 0, 4, 5 });

            migrationBuilder.InsertData(
                table: "Operation",
                columns: new[] { "Id", "Amount", "OperationTypeId", "PersonFromId", "PersonToId" },
                values: new object[] { 9, 5.0, 0, 3, 4 });

            migrationBuilder.InsertData(
                table: "Operation",
                columns: new[] { "Id", "Amount", "OperationTypeId", "PersonFromId", "PersonToId" },
                values: new object[] { 8, 5.0, 0, 3, 4 });

            migrationBuilder.InsertData(
                table: "Operation",
                columns: new[] { "Id", "Amount", "OperationTypeId", "PersonFromId", "PersonToId" },
                values: new object[] { 7, 2.0, 1, 3, 2 });

            migrationBuilder.InsertData(
                table: "Operation",
                columns: new[] { "Id", "Amount", "OperationTypeId", "PersonFromId", "PersonToId" },
                values: new object[] { 6, 4.0, 0, 2, 3 });

            migrationBuilder.InsertData(
                table: "Operation",
                columns: new[] { "Id", "Amount", "OperationTypeId", "PersonFromId", "PersonToId" },
                values: new object[] { 5, 3.0, 0, 2, 3 });

            migrationBuilder.InsertData(
                table: "Operation",
                columns: new[] { "Id", "Amount", "OperationTypeId", "PersonFromId", "PersonToId" },
                values: new object[] { 4, 1.0, 1, 3, 1 });

            migrationBuilder.InsertData(
                table: "Operation",
                columns: new[] { "Id", "Amount", "OperationTypeId", "PersonFromId", "PersonToId" },
                values: new object[] { 3, 2.0, 0, 1, 3 });

            migrationBuilder.InsertData(
                table: "Operation",
                columns: new[] { "Id", "Amount", "OperationTypeId", "PersonFromId", "PersonToId" },
                values: new object[] { 2, 1.0, 1, 2, 1 });

            migrationBuilder.InsertData(
                table: "Operation",
                columns: new[] { "Id", "Amount", "OperationTypeId", "PersonFromId", "PersonToId" },
                values: new object[] { 19, 5.0, 0, 4, 5 });

            migrationBuilder.InsertData(
                table: "Operation",
                columns: new[] { "Id", "Amount", "OperationTypeId", "PersonFromId", "PersonToId" },
                values: new object[] { 20, 5.0, 0, 4, 5 });

            migrationBuilder.CreateIndex(
                name: "IX_Operation_OperationTypeId",
                table: "Operation",
                column: "OperationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Operation_PersonFromId",
                table: "Operation",
                column: "PersonFromId");

            migrationBuilder.CreateIndex(
                name: "IX_Operation_PersonToId",
                table: "Operation",
                column: "PersonToId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Operation");

            migrationBuilder.DropTable(
                name: "OperationType");

            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
