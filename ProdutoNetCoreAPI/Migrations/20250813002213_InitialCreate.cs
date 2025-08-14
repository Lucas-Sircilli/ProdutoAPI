using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProdutoNetCoreAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    pk_int_idItem = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    str_nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    str_descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bit_ativo = table.Column<bool>(type: "bit", nullable: false),
                    dec_Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    int_saldo = table.Column<int>(type: "int", nullable: false),
                    str_EAN = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.pk_int_idItem);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
