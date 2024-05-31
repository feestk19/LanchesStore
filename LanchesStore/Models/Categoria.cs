﻿#region Manutenções/Implementações
/*
 * 31/05/2024 - Implementação inicial
 */
#endregion

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesStore.Models;

[Table("Categoria")]
public class Categoria
{
    [Key]
    public int CategoriaId { get; set; }

    [StringLength(100, ErrorMessage = "O tamanho máximo é 100 caracteres!")]
    [Required(ErrorMessage = "Informe o nome da categoria")]
    [Display(Name ="Nome")]
    public string CategoriaNome { get; set; }

    [StringLength(200, ErrorMessage = "O tamanho máximo é 200 caracteres!")]
    [Required(ErrorMessage = "Informe a descrição da categoria")]
    [Display(Name = "Descrição")]
    public string CategoriaDescricao { get; set; }

    public List<Lanche> Lanches { get; set;}
}

