using BibliotecasPOO.Models;

namespace BibliotecasPOO;


internal class Program
{
    static void Main(string[] args)
    {

        Livro livro2 = new("Receitas de Bolo", ["Receitas", "Doces"], "Professor Luan", 300, "978-758975389");
        livro2.MostrarInformacoes();
    }
}
