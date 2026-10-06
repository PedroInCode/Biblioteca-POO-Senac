using BibliotecasPOO.Models;

namespace BibliotecasPOO;


internal class Program
{
    static void Main(string[] args)
    {

        Livro livro2 = new("Receitas de Bolo", ["Receitas", "Doces"], "Professor Luan", 300, "978-758975389");
        livro2.MostrarInformacoes();

        Midia midia1 = new("10 minutos", "10-10-2026", "Midia Teste", ["Sla1", "Sla2"], "Gustava Guanabara");
        midia1.MostrarInformacoes();
    }
}
