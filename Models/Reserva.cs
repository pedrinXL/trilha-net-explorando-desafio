using System;
using System.Collections.Generic;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new InvalidOperationException("Capacidade insuficiente da suíte para o número de hóspedes.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            if (Hospedes != null)
            {
                return Hospedes.Count;
            }
            else
            {
                return 0;
            }
        }

        public decimal CalcularValorDiaria()
        {
            if (DiasReservados >= 10)
            {
                decimal desconto = Suite.ValorDiaria * DiasReservados * 0.10m;
                return (DiasReservados * Suite.ValorDiaria) - desconto;
            }
            else
            {
                return DiasReservados * Suite.ValorDiaria;
            }
        }
    }
}
