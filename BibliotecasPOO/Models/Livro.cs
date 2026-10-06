using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecasPOO.Models;

internal class Livro : Material
{
    private string _isbn;
    private int _qtdPaginas;

    public string ISBN { get => this._isbn;  set => this._isbn = value; }
    public int QuantidadePaginas { get => this._qtdPaginas; set => this._qtdPaginas = value; }

    public Livro( string Titulo, List<string> assuntos, string autor, int qtdPaginas, string isbn)
        : base(Titulo, assuntos, autor)
    {
        this._isbn = isbn;
        this._qtdPaginas = qtdPaginas; 
    }

    public override void MostrarInformacoes()
    {
        base.MostrarInformacoes();
        Console.WriteLine($"Quantidade de Páginas: {this._qtdPaginas}");
        Console.WriteLine($"ISBN: {this._isbn}");
        Console.WriteLine("-----------------------------------------");
    }
}
