﻿namespace ExemploEF.Models
{
    public class Produto
    {
        public Guid ProdutoId { get; set; }

        public string Nome { get; set; }

        public string Estoque { get; set; }
        public Guid CategoriaId { get; set; }

        public Categoria? categoria { get; set;}
    }
}
