using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LmsData.Migrations
{
    public partial class InitialDbConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(nullable: true),
                    EndDate = table.Column<DateTime>(nullable: true),
                    IsCurrent = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Port = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Computers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    RamInMegabytes = table.Column<int>(nullable: false),
                    Processor = table.Column<string>(nullable: true),
                    OperatingSystem = table.Column<string>(nullable: true),
                    HddSize = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    CaseType = table.Column<int>(nullable: false),
                    SerialNumber = table.Column<string>(nullable: true),
                    DateReceived = table.Column<DateTime>(nullable: false),
                    TestedBy = table.Column<string>(nullable: true),
                    TestDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Computers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mentors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Mobile = table.Column<string>(nullable: true),
                    Speciality = table.Column<string>(nullable: true),
                    WWCCVerifiedDate = table.Column<DateTime>(nullable: false),
                    CanWorkWithChildren = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mentors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    SessionType = table.Column<int>(nullable: false),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Incidents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OccuranceDate = table.Column<DateTime>(nullable: false),
                    Details = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    ReportedById = table.Column<int>(nullable: true),
                    SessionModelId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incidents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Incidents_Mentors_ReportedById",
                        column: x => x.ReportedById,
                        principalTable: "Mentors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Incidents_Sessions_SessionModelId",
                        column: x => x.SessionModelId,
                        principalTable: "Sessions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    DateEnrolled = table.Column<DateTime>(nullable: false),
                    PhotoPath = table.Column<string>(nullable: true),
                    BookedSession = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsCadet = table.Column<bool>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    IncidentModelId = table.Column<int>(nullable: true),
                    SessionModelId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Members_Incidents_IncidentModelId",
                        column: x => x.IncidentModelId,
                        principalTable: "Incidents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Members_Sessions_SessionModelId",
                        column: x => x.SessionModelId,
                        principalTable: "Sessions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Expectations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    MemberModelId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expectations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Expectations_Members_MemberModelId",
                        column: x => x.MemberModelId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KnownIssues",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    MemberModelId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KnownIssues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KnownIssues_Members_MemberModelId",
                        column: x => x.MemberModelId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Computers",
                columns: new[] { "Id", "Brand", "CaseType", "DateReceived", "HddSize", "Model", "Notes", "OperatingSystem", "Processor", "RamInMegabytes", "SerialNumber", "TestDate", "TestedBy" },
                values: new object[,]
                {
                    { 1, "Lenovo", 2, new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "500Gb", "", null, "Windows 10 Pro", "Pentium Core2 Duo", 4096, "LEN-123", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Riley" },
                    { 2, "Lenovo", 2, new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "250Gb", "", null, "Windows 10 Pro", "Pentium Core2 Duo", 4096, "LEN-3452", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Riley" },
                    { 3, "Dell", 0, new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "500Gb", "Optiplex 610", null, "Ubuntu 19.04 Desktop", "Pentium Core i3 Gen 4", 4096, "LEN-3452", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jarred" }
                });

            migrationBuilder.InsertData(
                table: "Expectations",
                columns: new[] { "Id", "Description", "MemberId", "MemberModelId", "Type" },
                values: new object[,]
                {
                    { 1, "Brodie is Bob's Grandson", 1, null, 1 },
                    { 2, "Brodie is enrolled in both sessions", 1, null, 2 },
                    { 3, "Tyreece Parent Expectation 1", 2, null, 1 },
                    { 4, "Dex likes coding and Minecraft", 3, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "KnownIssues",
                columns: new[] { "Id", "Description", "MemberId", "MemberModelId" },
                values: new object[,]
                {
                    { 5, "Very talkative", 4, null },
                    { 3, "Has OCD", 2, null },
                    { 4, "Has ADHD", 2, null },
                    { 1, "Brodie does not like a lot of noise", 1, null },
                    { 2, "Dex is a bit shy", 3, null }
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "BookedSession", "DateEnrolled", "DateOfBirth", "FirstName", "IncidentModelId", "IsActive", "IsCadet", "LastName", "Notes", "PhotoPath", "SessionModelId" },
                values: new object[,]
                {
                    { 1, 3, new DateTime(2019, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2006, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brodie", null, true, false, "O'Hara", null, null, null },
                    { 2, 1, new DateTime(2019, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2004, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tyreece", null, true, false, "Dureaux", null, null, null },
                    { 3, 1, new DateTime(2019, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dexter", null, true, false, "McMahon", null, null, null },
                    { 4, 1, new DateTime(2019, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sonnie", null, true, false, "Jones", null, null, null },
                    { 5, 2, new DateTime(2019, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2007, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lilly", null, true, false, "Fletcher", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Mentors",
                columns: new[] { "Id", "CanWorkWithChildren", "Email", "FirstName", "LastName", "Mobile", "Speciality", "Status", "WWCCVerifiedDate" },
                values: new object[,]
                {
                    { 4, true, "mark@thelab.grafton.internal", "Mark", "Bathgate", "", "", 3, new DateTime(2019, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, true, "steve@thelab.grafton.internal", "Steve", "Teece", "(0421) 420-141", "Programming", 1, new DateTime(2019, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, true, "duncan@thelab.grafton.internal", "Duncan", "Sage", "", "3D Graphics", 1, new DateTime(2019, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, true, "jarred@thelab.grafton.internal", "Jarred", "Chaffey", "", "Hardware", 2, new DateTime(2019, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, true, "ben@thelab.grafton.internal", "Ben", "McKenzie", "", "Gaming", 2, new DateTime(2019, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Expectations_MemberModelId",
                table: "Expectations",
                column: "MemberModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_ReportedById",
                table: "Incidents",
                column: "ReportedById");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_SessionModelId",
                table: "Incidents",
                column: "SessionModelId");

            migrationBuilder.CreateIndex(
                name: "IX_KnownIssues_MemberModelId",
                table: "KnownIssues",
                column: "MemberModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Members_IncidentModelId",
                table: "Members",
                column: "IncidentModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Members_SessionModelId",
                table: "Members",
                column: "SessionModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "Computers");

            migrationBuilder.DropTable(
                name: "Expectations");

            migrationBuilder.DropTable(
                name: "KnownIssues");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "Incidents");

            migrationBuilder.DropTable(
                name: "Mentors");

            migrationBuilder.DropTable(
                name: "Sessions");
        }
    }
}
