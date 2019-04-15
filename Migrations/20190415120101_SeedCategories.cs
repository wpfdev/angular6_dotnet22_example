using Microsoft.EntityFrameworkCore.Migrations;

namespace Test2.Migrations
{
    public partial class SeedCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categories (Name) VALUES ('Wear'), ('Shoes')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categories where Name in ('Shoes', 'Wear')");
        }
    }
}
