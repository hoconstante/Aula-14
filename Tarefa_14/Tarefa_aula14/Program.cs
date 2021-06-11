using System;

namespace Tarefa_aula14
{
        class Program {
            static void Main(string[] args){

                Fornec michaelsoft = new Fornec("Michaelsóft", "Rua tal, São Luiz, Maranhão, n. 776", "12.345.678/4223-22", "Michaelsóft_falacomnois@foraolhar.com");
                Fornec aldobo = new Fornec("Aldobo", "Rua aqui, Maceió, Alagoas, n. 1080", "13.654.886/9987-67", "Aldobo.contacto@gemeio.com");
                Fornec corehul = new Fornec("Corehul", "Rua acolá, Manaus, Amazonas, n. 12", "12.680.729/3221-22", "Corehul_falacomnois@quentemeio.com");

                Licensa rwindols = new Licensa("Michaelsóft Rwildols", 699.90, "SUAA-HE52-W6WG-B8Y9", michaelsoft);
                Assinatura alface123 = new Assinatura("Michaelsóft Alface", 39.90, 12, "5GNX-VM6Y-L6W8-SCPC", michaelsoft);
                Assinatura cottonshopi = 
                     new Assinatura("Aldobo Cottonshopi", mensalidade: 89.90, 12, "H84A-8QDF-4XPT-A2WZ", aldobo);
                Assinatura premillere =
                     new Assinatura("Aldobo Premillere", mensalidade: 89.90, 12, "RLBD-YTRZ-UPH7-VQGM", aldobo);
                Licensa corehulDreus = new Licensa("Corehul Dreus", 2999.90, "XZLT-CXL9-SLHV-99UM", corehul);

                ProdutoFisico mausi = new ProdutoFisico("Mausi Michaelsóft", 89.90, 12.99, michaelsoft);
                ProdutoFisico lepetope = new ProdutoFisico("Lepetope Dehul", 3499.90, 123.45, michaelsoft);

                Guardado estoque = new Guardado();

                estoque.Adicionar(rwindols, 6);
                estoque.Adicionar(alface123, 9);
                estoque.Adicionar(cottonshopi, 5);
                estoque.Adicionar(premillere, 3);
                estoque.Adicionar(corehulDreus, 6);
                estoque.Adicionar(mausi, 4);
                estoque.Adicionar(lepetope, 3);
                

            Cliente hermenegildo = new Cliente("Hermenegildo Benevides", "123.456.789-10");
                Cliente zoroastra = new Cliente("Zoroastra Muad'dib", "109.876.543-21");

                Carrinho carrinhoZoroastra = new Carrinho();

                carrinhoZoroastra.Adicionar(rwindols);
                carrinhoZoroastra.Adicionar(alface123, 3);
                carrinhoZoroastra.Adicionar(cottonshopi);
                carrinhoZoroastra.Adicionar(premillere);
                carrinhoZoroastra.Adicionar(corehulDreus);
                carrinhoZoroastra.Adicionar(mausi, 3);
                carrinhoZoroastra.Adicionar(lepetope);
                carrinhoZoroastra.ImprimirCarrinho();

                Comprar compraZoroastra = new Comprar(zoroastra, carrinhoZoroastra, estoque);

                compraZoroastra.Guardado.AtualizarEstoque(carrinhoZoroastra);
                
                Relatorio relatorioArtistico = new Relatorio("Relatorio Artístico",
                   "Este relatório apresenta todos os softwares artisticos vendidos na loja.");
                relatorioArtistico.AdicionarItem(cottonshopi);
                relatorioArtistico.AdicionarItem(premillere);
                relatorioArtistico.AdicionarItem(corehul);
                relatorioArtistico.ImprimirRelatorio();

                Relatorio relatorioClientes = new Relatorio("Relatório de Clientes",
                   "Este relatório apresenta uma lista de todos os clientes que compraram no mês de abril");
                relatorioClientes.AdicionarItem(hermenegildo);
                relatorioClientes.AdicionarItem(zoroastra);
                relatorioClientes.ImprimirRelatorio();

            Relatorio relatorioCompras = new Relatorio("Relatório de Compra",
                   "Este relatório apresenta uma lista de todos as compras que ocorreram no mês de abril");
            relatorioCompras.AdicionarItem(compraZoroastra);
            relatorioCompras.ImprimirRelatorio();
        }
    }
}
