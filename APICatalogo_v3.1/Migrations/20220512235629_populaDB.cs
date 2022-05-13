using Microsoft.EntityFrameworkCore.Migrations;

namespace APICatalogo_v3._1.Migrations
{
    public partial class populaDB : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Categorias(Nome,ImagemUrl) VALUES('Bebidas','img.jpg')");
            mb.Sql("INSERT INTO Categorias(Nome,ImagemUrl) VALUES('Comida','img.jpg')");
            mb.Sql("INSERT INTO Categorias(Nome,ImagemUrl) VALUES('Sobremesa','img.jpg')");

            //mb.Sql("INSERT INTO Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaID) VALUES('Coca-Cola Diet', 'Refrigerante de Cola 350 ml', 5.45, 'cocacola.jpg', 50, now(),1)");
            //mb.Sql("INSERT INTO Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaID) VALUES('x-Salada', 'x-salada caseiro', 5.45, 'xsalada.jpg', 50, now(),2)");
            //mb.Sql("INSERT INTO Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaID) VALUES('Sorvete açai', 'Açai com qualquer acompanhamento', 5.45, 'acai.jpg', 50, now(),3)");

        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM Categorias");
            mb.Sql("DELETE FROM Produtos");
        }
    }
}
