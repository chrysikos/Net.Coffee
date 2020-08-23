using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Net.Coffee.Server.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false, defaultValueSql: "NEWSEQUENTIALID()"),
                    IsActive = table.Column<bool>(nullable: false),
                    Contact_FirstName = table.Column<string>(nullable: true),
                    Contact_LastName = table.Column<string>(nullable: true),
                    Contact_Address_City = table.Column<string>(nullable: true),
                    Contact_Address_Street = table.Column<string>(nullable: true),
                    Contact_Address_Number = table.Column<short>(nullable: true),
                    Contact_Address_PostalCode = table.Column<string>(nullable: true),
                    Contact_CellPhone = table.Column<string>(nullable: true),
                    Contact_Phone = table.Column<string>(nullable: true),
                    Contact_Email = table.Column<string>(nullable: true),
                    Credentials_Username = table.Column<string>(nullable: true),
                    Credentials_Password = table.Column<string>(nullable: true),
                    DiscountPercentage = table.Column<decimal>(type: "decimal(19, 4)", nullable: false, defaultValue: 0.00m)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
