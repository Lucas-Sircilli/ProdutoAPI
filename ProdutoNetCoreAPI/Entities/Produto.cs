using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProdutoNetCoreAPI.Entities
{

    #region Produto
    
    public class Produto
    {
        /// <summary>
        /// Chave Primária da Tabela de produtos (Produtos).
        /// </summary>
        [Column("pk_int_idItem")]
        public int Id { get; set; }

        /// <summary>
        /// Representa o nome do produto.
        /// </summary>
        [Column("str_nome")]
        public string? Nome { get; set; }

        /// <summary>
        /// Representa a descrição do produto.
        /// </summary>
        [Column("str_descricao")]
        public string? Descricao { get; set; }

        /// <summary>
        /// Representa o status do cadastro no sistema.
        /// </summary>
        [Column("bit_ativo")]
        public bool Ativo { get; set; }

        /// <summary>
        /// Representa o valor do produto.
        /// </summary>
        [Column("dec_Valor")]
        public decimal Valor { get; set; }

        /// <summary>
        /// Representa o saldo do produto.
        /// </summary>
        [Column("int_saldo")]
        public int Saldo { get; set; }

        /// <summary>
        /// Representa o EAN(GTIN) do produto (Número Global de Item Comercial).
        /// </summary>
        [Column("str_EAN")]
        public string? EAN { get; set; }

    }

    #endregion
}
