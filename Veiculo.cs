using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veiculo_aplicacao
{
    public abstract class Veiculo
    {
        private string marca;
        private string modelo;
        private double preco;
        private string combustivel;
        private string placa;
        private string cor;
        private int chassi;

        public Veiculo()
        {
            this.marca = null;
            this.modelo = null;
            this.preco = 0;
            this.combustivel = null;
            this.placa = null;
            this.cor = null;
            this.chassi = 0;
        }
        public Veiculo(string marca, string modelo, double preco, string combustivel, string placa, string cor, int chassi, bool freioAbs, double peso)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Preco = preco;
            this.Combustivel = combustivel;
            this.Placa = placa;
            this.Cor = cor;
            this.Chassi = chassi;

        }
        public string Marca {
            get { return this.marca; }
            set { this.marca = value; }
        }

        public string Modelo
        {
            get { return this.modelo; }
            set { this.modelo = value; }
        }

        public double Preco
        {
            get { return this.preco; }
            set { this.preco = value; }
        }

        public string Combustivel
        {
            get { return this.combustivel; }
            set { this.combustivel = value; }
        }

        public string Placa
        {
            get { return this.placa; }
            set { this.placa = value; }
        }

        public string Cor
        {
            get { return this.cor; }
            set { this.cor = value; }
        }

        public int Chassi
        {
            get { return this.chassi; }
            set { this.chassi = value; }
        }


        public abstract String RegistrarVeiculo();
        // public abstract String VenderVeiculo();
        // public abstract String ExcluirVeiculo();

    }
}
