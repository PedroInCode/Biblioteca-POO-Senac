using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecasPOO.Models;

internal class Usuario
{
    private Matricula _matricula;
    private string _nome;
    private bool _podeEmprestar;
    private List<Emprestimo> _emprestimos;

    public List<Emprestimo> Emprestimos { get => this._emprestimos; set => this._emprestimos = value; }
    public Matricula Matricula { get => this._matricula; set => this._matricula = value; }
    public string Nome { get => this._nome; set => this._nome = value; }
    public bool PodeEmprestar { get => this._podeEmprestar; set => this._podeEmprestar = value; }

    public Usuario(Matricula matricula, string nome)
    {
        this.Matricula = matricula;
        this.Nome = nome;
        this.PodeEmprestar = true;
        this._emprestimos = new List<Emprestimo>();
    }

    public void Registrar(Emprestimo emprestimo)
    {

    }
}
