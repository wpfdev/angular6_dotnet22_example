using Microsoft.EntityFrameworkCore.Migrations;

namespace Test2.Migrations
{
    public partial class SeedOptions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Options (Name,ProductId) VALUES ('Black',(SELECT Id FROM Products WHERE Name = 'T-Shirt')), ('White',(SELECT Id FROM Products WHERE Name = 'T-Shirt')),('Red',(SELECT Id FROM Products WHERE Name = 'T-Shirt'))");
            migrationBuilder.Sql("INSERT INTO Options (Name,ProductId) VALUES ('Sporting',(SELECT Id FROM Products WHERE Name = 'Sneakers')), ('Casual',(SELECT Id FROM Products WHERE Name = 'Sneakers')),('For Running',(SELECT Id FROM Products WHERE Name = 'Sneakers'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE * FROM Options");
        }
    }
}
