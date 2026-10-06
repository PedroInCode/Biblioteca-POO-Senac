using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecasPOO.Models;

internal class Midia : Material
{
    private string _tempo;
    private string _anoProducao;

    public string Tempo { get => this._tempo; set => this._tempo = value; }
    public string AnoProducao { get => this._anoProducao; set => this._anoProducao = value; }


    public Midia(string tempo, string anoProducao, string Titulo, List<string> assuntos, string? autor = null)
        : base(Titulo, assuntos, autor)
    {
        this._tempo = tempo;
        this._anoProducao = anoProducao;
    }

    public override void MostrarInformacoes()
    {
        base.MostrarInformacoes();
        Console.WriteLine($"Tempo: {this._tempo}");
        Console.WriteLine($"Ano de Produção: {this._anoProducao}");
        Console.WriteLine("-----------------------------------------");
    }
}
