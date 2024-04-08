using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Auth_Login.Migrations
{
    /// <inheritdoc />
    public partial class a : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          

            migrationBuilder.CreateTable(
                name: "product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OldPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Rating = table.Column<float>(type: "real", nullable: false),
                    ReviewsCount = table.Column<int>(type: "int", nullable: false),
                    SoldCount = table.Column<int>(type: "int", nullable: false),
                    Warranty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Protection = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Customization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Design = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PriceNegotiable = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "shoppingcart",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subtotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Shipping = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Tax = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shoppingcart", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "signup",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contact = table.Column<int>(type: "int", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_signup", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "cartitem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ShoppingCartViewModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cartitem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_cartitem_shoppingcart_ShoppingCartViewModelId",
                        column: x => x.ShoppingCartViewModelId,
                        principalTable: "shoppingcart",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_cartitem_ShoppingCartViewModelId",
                table: "cartitem",
                column: "ShoppingCartViewModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cartitem");

            migrationBuilder.DropTable(
                name: "login");

            migrationBuilder.DropTable(
                name: "product");

            migrationBuilder.DropTable(
                name: "signup");

            migrationBuilder.DropTable(
                name: "shoppingcart");
        }
    }
}
