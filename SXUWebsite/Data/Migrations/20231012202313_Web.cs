using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SXUWebsite.Data.Migrations
{
    public partial class Web : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Brokerages",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<int>(type: "int", nullable: false),
                    CountryCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ConfirmPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    logoPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Liceinces = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Approval = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brokerages", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CatName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "ContactUs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Investors",
                columns: table => new
                {
                    InvId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SSN = table.Column<int>(type: "int", nullable: false),
                    InvFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InvSecondName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InvLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InvAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BOD = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalBalance = table.Column<float>(type: "real", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ConfirmPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    STATUS = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Investors", x => x.InvId);
                });

            migrationBuilder.CreateTable(
                name: "ListedComs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ConfirmPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    logoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LiceincePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    STATUS = table.Column<bool>(type: "bit", nullable: false),
                    Approval = table.Column<bool>(type: "bit", nullable: true),
                    RegisterTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CategoryFK = table.Column<int>(type: "int", nullable: false),
                    BrokerageID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListedComs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ListedComs_Brokerages_BrokerageID",
                        column: x => x.BrokerageID,
                        principalTable: "Brokerages",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ListedComs_Category_CategoryFK",
                        column: x => x.CategoryFK,
                        principalTable: "Category",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    StockId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Capital = table.Column<float>(type: "real", nullable: false),
                    StockNum = table.Column<int>(type: "int", nullable: false),
                    StockPrice = table.Column<float>(type: "real", nullable: false),
                    StocksForSell = table.Column<int>(type: "int", nullable: false),
                    listedid = table.Column<int>(type: "int", nullable: false),
                    investorsInvId = table.Column<int>(type: "int", nullable: true),
                    OperationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IPODate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StockStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.StockId);
                    table.ForeignKey(
                        name: "FK_Stocks_Investors_investorsInvId",
                        column: x => x.investorsInvId,
                        principalTable: "Investors",
                        principalColumn: "InvId");
                    table.ForeignKey(
                        name: "FK_Stocks_ListedComs_listedid",
                        column: x => x.listedid,
                        principalTable: "ListedComs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ListedComs_BrokerageID",
                table: "ListedComs",
                column: "BrokerageID");

            migrationBuilder.CreateIndex(
                name: "IX_ListedComs_CategoryFK",
                table: "ListedComs",
                column: "CategoryFK");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_investorsInvId",
                table: "Stocks",
                column: "investorsInvId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_listedid",
                table: "Stocks",
                column: "listedid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactUs");

            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.DropTable(
                name: "Investors");

            migrationBuilder.DropTable(
                name: "ListedComs");

            migrationBuilder.DropTable(
                name: "Brokerages");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");
        }
    }
}
