// See https://aka.ms/new-console-template for more information
using System.Net.Mail;
using TesteFioTecBiblioteca.Services;

Console.WriteLine("Hello, World!");

// Define o caminho da pasta a ser varrida
string pasta = @"C:\MinhaPasta";

EmailService emailService = new EmailService();

emailService.MensagemPodeInserir(pasta);

// Fecha a conexão com o banco de dados
emailService.FecharConexao();

// Aguarda o usuário pressionar uma tecla para encerrar o programa
Console.WriteLine("Processamento concluído. Pressione uma tecla para encerrar o programa.");
Console.ReadKey();
