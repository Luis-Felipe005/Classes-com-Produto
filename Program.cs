

using ClasseDeProduto;

Console.WriteLine("Olá, seja bem-vindo a loja Cunha!");

Console.WriteLine("\n\n");


Produto camisa_Nike= new Produto();



camisa_Nike.nome = "Camisa Nike";
camisa_Nike.quantidade = 300;
camisa_Nike.preco = 70.00;
camisa_Nike.descricao = "Camisa Nike Original - 100 algodão. Possui um ótimo custo benefício";
camisa_Nike.status = true;

camisa_Nike.ProdutosNoConsole();

Console.WriteLine("\n\n");


Produto tenis_Adidas = new Produto();



tenis_Adidas.nome = "Tênis Adidas";
tenis_Adidas.quantidade = 150;
tenis_Adidas.preco = 300.00;
tenis_Adidas.descricao = "Tênis Adidas original - Excelente conforto e elásticidade nos pés!";
tenis_Adidas.status = true;

tenis_Adidas.ProdutosNoConsole();

Console.WriteLine("\n\n");



Produto chinelo_Lacoste= new Produto(); 

chinelo_Lacoste.nome = "Chinelo Lacoste";
chinelo_Lacoste.quantidade = 100;
chinelo_Lacoste.preco = 200.00;
chinelo_Lacoste.descricao = "Chinelo lacoste Original - Excelente conforto e elásticidade nos pés!";
chinelo_Lacoste.status = false;

chinelo_Lacoste.DesativarProduto();
chinelo_Lacoste.ProdutosNoConsole();

Console.ReadKey();







