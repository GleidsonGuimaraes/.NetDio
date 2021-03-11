using System;

namespace DIO.Series
{
    public class Serie : EntidadeBase
    {
        //Atributos
        private Genero Genero { get; set;}
        private string Titulo { get; set;}
        private string Descricao { get; set;}
        private int Ano { get; set;}
        private bool Excluido { get; set;}

        public Serie(int id, Genero genero, string titulo, string descricao, int ano) {
            this.ID = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
        }

        public override string ToString()
        {
            /* Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newLine?view-netcore-3.1 */
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Excluído: " + this.Excluido;
            return retorno;
        }

        public string retornaTitulo() {
            return this.Titulo;
        }

        public int retornaId() {
            return this.ID;
        }
        public bool retornaExcluido() {
            return this.Excluido;
        }

        public void excluir() {
            this.Excluido = true;
        }
    }
}