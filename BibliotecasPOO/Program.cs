using BibliotecasPOO.Models;

namespace BibliotecasPOO;


internal class Program
{
    static void Main(string[] args)
    {
        Material livro = new("Receitas de Bolo", ["Receitas", "Doces"], "Professor Luan");

        livro.MostrarInformacoes();
    }
}
