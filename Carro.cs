using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veiculo_aplicacao
{
        public class Carro : Veiculo
        {
 
        private int portas;
        private int capacidadeBagagem;
        private string categoriaCarro;

        public Carro()
        {
            this.portas = 0;
            this.capacidadeBagagem = 0;
            this.categoriaCarro = null;
        }
        public Carro(string marca, string modelo, double preco, string combustivel, string placa, string cor, int chassi, int portas, int capacidadeBagagem, string categoriaCarro)
         
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Preco = preco;
            this.Combustivel = combustivel;
            this.Placa = placa;
            this.Cor = cor;
            this.Chassi = chassi;
            this.Portas = portas;
            this.CapacidadeBagagem = capacidadeBagagem;
            this.CategoriaCarro = categoriaCarro;
        }

        public int Portas
        {
            get { return this.portas; }
            set { this.portas = value; }
        }

        public int CapacidadeBagagem
        {
            get { return this.capacidadeBagagem; }
            set { this.capacidadeBagagem = value; }
        }

        public string CategoriaCarro
        {
            get { return this.categoriaCarro; }
            set { this.categoriaCarro = value; }
        }

        public override String RegistrarVeiculo()
        {
            String s = String.Empty;
            s = ($"Marca: {this.Marca},\r\n Modelo: {this.Modelo},\r\n Preço: {this.Preco},\r\n Combustível: {this.Combustivel},\r\n Placa: {this.Placa},\r\n Cor: {this.Cor},\r\n Chassi: {this.Chassi}, \r\n Portas: {this.Portas}, \r\n Capacidade Bagagem: {this.CapacidadeBagagem}, \r\n Categoria: {this.CategoriaCarro}").ToString();
            return s;
        }

    }
}
