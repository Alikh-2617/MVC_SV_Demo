using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Continents",
                columns: table => new
                {
                    ContinentName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Create = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Continents", x => x.ContinentName);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    JobName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Salary = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.JobName);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Create = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ContinentName = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryName);
                    table.ForeignKey(
                        name: "FK_Countries_Continents_ContinentName",
                        column: x => x.ContinentName,
                        principalTable: "Continents",
                        principalColumn: "ContinentName");
                });

            migrationBuilder.CreateTable(
                name: "cities",
                columns: table => new
                {
                    PostNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CityName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Create = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CountryName = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cities", x => x.PostNumber);
                    table.ForeignKey(
                        name: "FK_cities_Countries_CountryName",
                        column: x => x.CountryName,
                        principalTable: "Countries",
                        principalColumn: "CountryName");
                });

            migrationBuilder.CreateTable(
                name: "Houses",
                columns: table => new
                {
                    HouseNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Create = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modify = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CityPostNumber = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Houses", x => x.HouseNumber);
                    table.ForeignKey(
                        name: "FK_Houses_cities_CityPostNumber",
                        column: x => x.CityPostNumber,
                        principalTable: "cities",
                        principalColumn: "PostNumber");
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EfterName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Register = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modify = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CityPostNumber = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    HouseNumber = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.PersonId);
                    table.ForeignKey(
                        name: "FK_People_Houses_HouseNumber",
                        column: x => x.HouseNumber,
                        principalTable: "Houses",
                        principalColumn: "HouseNumber");
                    table.ForeignKey(
                        name: "FK_People_cities_CityPostNumber",
                        column: x => x.CityPostNumber,
                        principalTable: "cities",
                        principalColumn: "PostNumber");
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    RegisterNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Create = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modify = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OwnerPersonId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.RegisterNumber);
                    table.ForeignKey(
                        name: "FK_Cars_People_OwnerPersonId",
                        column: x => x.OwnerPersonId,
                        principalTable: "People",
                        principalColumn: "PersonId");
                });

            migrationBuilder.CreateTable(
                name: "JobPerson",
                columns: table => new
                {
                    JobsJobName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    PeoplePersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobPerson", x => new { x.JobsJobName, x.PeoplePersonId });
                    table.ForeignKey(
                        name: "FK_JobPerson_Jobs_JobsJobName",
                        column: x => x.JobsJobName,
                        principalTable: "Jobs",
                        principalColumn: "JobName",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobPerson_People_PeoplePersonId",
                        column: x => x.PeoplePersonId,
                        principalTable: "People",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "RegisterNumber", "Color", "Create", "Model", "Modify", "OwnerPersonId" },
                values: new object[] { "415 GTA", "Red", new DateTime(2023, 4, 10, 16, 54, 5, 208, DateTimeKind.Local).AddTicks(3777), "volo", null, null });

            migrationBuilder.InsertData(
                table: "Continents",
                columns: new[] { "ContinentName", "Create" },
                values: new object[] { "EURO", new DateTime(2023, 4, 10, 16, 54, 5, 208, DateTimeKind.Local).AddTicks(3845) });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryName", "ContinentName", "Create" },
                values: new object[] { "danmark", null, new DateTime(2023, 4, 10, 16, 54, 5, 208, DateTimeKind.Local).AddTicks(3809) });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "HouseNumber", "CityPostNumber", "Create", "Modify" },
                values: new object[] { 1, null, new DateTime(2023, 4, 10, 16, 54, 5, 208, DateTimeKind.Local).AddTicks(3741), null });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "JobName", "Salary" },
                values: new object[] { "programer", 35000 });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "PersonId", "Birthday", "CityPostNumber", "EfterName", "HouseNumber", "Modify", "Name", "Register" },
                values: new object[] { 11111111, new DateTime(2023, 4, 10, 16, 54, 5, 208, DateTimeKind.Local).AddTicks(3639), null, "khawari", null, null, "Ali", new DateTime(2023, 4, 10, 16, 54, 5, 208, DateTimeKind.Local).AddTicks(3706) });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "PostNumber", "CityName", "CountryName", "Create" },
                values: new object[] { "415 52", "Östersund", null, new DateTime(2023, 4, 10, 16, 54, 5, 208, DateTimeKind.Local).AddTicks(3872) });

            migrationBuilder.InsertData(
                table: "JobPerson",
                columns: new[] { "JobsJobName", "PeoplePersonId" },
                values: new object[] { "programer", 11111111 });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_OwnerPersonId",
                table: "Cars",
                column: "OwnerPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_cities_CountryName",
                table: "cities",
                column: "CountryName");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_ContinentName",
                table: "Countries",
                column: "ContinentName");

            migrationBuilder.CreateIndex(
                name: "IX_Houses_CityPostNumber",
                table: "Houses",
                column: "CityPostNumber");

            migrationBuilder.CreateIndex(
                name: "IX_JobPerson_PeoplePersonId",
                table: "JobPerson",
                column: "PeoplePersonId");

            migrationBuilder.CreateIndex(
                name: "IX_People_CityPostNumber",
                table: "People",
                column: "CityPostNumber");

            migrationBuilder.CreateIndex(
                name: "IX_People_HouseNumber",
                table: "People",
                column: "HouseNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "JobPerson");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "Houses");

            migrationBuilder.DropTable(
                name: "cities");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Continents");
        }
    }
}
