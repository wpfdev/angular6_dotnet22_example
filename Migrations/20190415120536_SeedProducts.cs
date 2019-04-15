using Microsoft.EntityFrameworkCore.Migrations;

namespace Test2.Migrations
{
    public partial class SeedProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Products (Name,Price,CategoryId) VALUES ('T-Shirt',1000,1), ('Jacket',2000,1), ('Jeans',1500,1)");
            migrationBuilder.Sql("INSERT INTO Products (Name,Price,CategoryId) VALUES ('Sneakers',1000,2), ('Oxfords',2000,2), ('Boots',3500,2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE * FROM Products");
        }
    }
}
