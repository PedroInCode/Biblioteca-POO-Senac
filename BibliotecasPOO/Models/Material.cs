using BibliotecasPOO.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecasPOO.Models;

internal abstract class Material
{
    protected string _titulo;
    protected string? _autor;
    protected List<string> _assuntos;
    protected StatusMaterial _statusEmprestimo;

    //Aplicar Filtros no Get e Set
    //public string Titulo {  get { return this.titulo.ToUpper(); } set { this.titulo = value.ToUpper(); } }

    public string Titulo { get => this._titulo.ToUpper(); set => this._titulo = value; }
    public string Autor { get => this._autor; set => this._autor = value; }
    public List<string> Assuntos { get => this._assuntos; set => this._assuntos = value; }
    public StatusMaterial StatusEmprestimo { get => this._statusEmprestimo; set => this._statusEmprestimo = value; }

    public Material(string Titulo,List<string>assuntos, string? autor = null)
    {
        this._titulo = Titulo;
        this._autor = autor;
        this._assuntos = assuntos;
    }

    public virtual void MostrarInformacoes()
    {
        Console.WriteLine($"Titulo: {this._titulo}");
        if (!string.IsNullOrEmpty(_autor))
            Console.WriteLine($"Autor: {this._autor}");

        Console.WriteLine($"Assuntos: {string.Join(", ", _assuntos)}");
    }

    //public decimal CalcularMulta(int diasAtraso)
    //{

    //}

    public void MarcarEmprestado()
    {
        this._statusEmprestimo = StatusMaterial.Emprestado;
    }

    public void MarcarDevolvido()
    {
        this._statusEmprestimo = StatusMaterial.Devolvido;
    }
}
