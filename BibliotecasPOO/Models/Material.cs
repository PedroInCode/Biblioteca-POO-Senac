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

    public Material(string Titulo, string? autor = null)
    {
        this._titulo = Titulo;
        this._autor = autor;
        this._assuntos = new List<string>();
    }

    //Aplicar Filtros no Get e Set
    //public string Titulo {  get { return this.titulo.ToUpper(); } set { this.titulo = value.ToUpper(); } }
}
