using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecasPOO.Models;

internal class Emprestimo
{
    private Usuario _usuario;
    private Material _material;
    private DateTime _dataPrevistaDevulucao;
    private DateTime? _dataDevolucao;
    private bool _ativo;
    private Multa? _multa;


    public Usuario Usuario { get => this._usuario; set => this._usuario = value; }
    public Material Material { get => this._material; set => this._material = value; }
    public DateTime DataPrevistaDevulucao { get => this._dataPrevistaDevulucao; set => this._dataPrevistaDevulucao = value; }
    public DateTime? DataDevolucao { get => this._dataDevolucao; set => this._dataDevolucao = value; }
    public bool Ativo { get => this._ativo; set => this._ativo = value; }
    public Multa? Multa { get => this._multa; set => this._multa = value; }

    public Emprestimo(Usuario usuario, Material material)
    {
        this._usuario = usuario;
        this._material = material;
    }

}
