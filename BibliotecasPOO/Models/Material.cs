using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecasPOO.Models;

internal class Material
{
    private string _titulo;
    private string? _autor;
    private List<string> _assuntos;

    public string Titulo { get; set; }
    public string Autor { get; set; }
    public List<string> Assuntos { get; set; }

    public Material(string Titulo,List<string>assuntos, string? autor = null)
    {
        this._titulo = Titulo;
        this._autor = autor;
        this._assuntos = assuntos;
    }

    public void MostrarInformacoes()
    {
        Console.WriteLine($"Titulo: {this._titulo}");
        if (!string.IsNullOrEmpty(_autor))
            Console.WriteLine($"Autor: {this._autor}");
        
        Console.WriteLine($"Assuntos: {string.Join(", ", _assuntos)}");
    }

    //Aplicar Filtros no Get e Set
    //public string Titulo {  get { return this.titulo.ToUpper(); } set { this.titulo = value.ToUpper(); } }
}
