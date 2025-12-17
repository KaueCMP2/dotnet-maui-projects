using System;
using System.Collections.Generic;

namespace WebMobile.Models;

public partial class Relato
{
    public int Id { get; set; }

    public string Relato1 { get; set; } = null!;

    public string Imagem { get; set; } = null!;

    public decimal Latitude { get; set; }

    public decimal Longitude { get; set; }

    public int? Usuarioid { get; set; }

    public virtual Usuario? Usuario { get; set; }
}
