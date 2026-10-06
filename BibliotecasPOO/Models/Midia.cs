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

    public Midia(string tempo, string anoProducao, string Titulo, List<string> assuntos, string? autor = null)
        : base(Titulo, assuntos, autor)
    {
        this._tempo = tempo;
        this._anoProducao = anoProducao;
    }

    public void mostrarInformacoes()
    {
        
    }
}
