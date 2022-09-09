using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veiculo_aplicacao
{
    public abstract class Caminhao : Veiculo
    {
        private string tipoCarga;
        private double capacidadeCarga;
        private string tipoCabine;
        private int eixo;

        public Caminhao()
        {
            this.tipoCarga = null;
            this.capacidadeCarga = 0.0;
            this.tipoCabine = null;
            this.eixo = 0;
        }
        public Caminhao(string marca, string modelo, double preco, string combustivel, string placa, string cor, int chassi, string tipoCarga, double capacidadeCarga, string tipoCabine, int eixo)

        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Preco = preco;
            this.Combustivel = combustivel;
            this.Placa = placa;
            this.Cor = cor;
            this.Chassi = chassi;
            this.TipoCarga = tipoCarga;
            this.CapacidadeCarga = capacidadeCarga;
            this.TipoCabine = tipoCabine;
            this.Eixo = eixo;
        }

        public string TipoCarga
        {
            get { return this.tipoCarga; }
            set { this.tipoCarga = value; }
        }

        public double CapacidadeCarga
        {
            get { return this.capacidadeCarga; }
            set { this.capacidadeCarga = value; }
        }

        public string TipoCabine
        {
            get { return this.tipoCabine; }
            set { this.tipoCabine = value; }
        }

        public int Eixo
        {
            get { return this.Eixo; }
            set { this.Eixo = value; }
        }
    }
}
