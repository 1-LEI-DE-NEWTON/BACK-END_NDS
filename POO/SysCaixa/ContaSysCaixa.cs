using System;
using SysCaixa;

namespace SysCaixa;

public class ContaBancaria
{    
    public ContaBancaria(double saldo, Usuario usuario)
    {
        Saldo = saldo;
        Usuario = usuario;
    }
    public double Saldo { get; set; }
    public Usuario Usuario { get; set; }
}