using System;
using System.Collections.Generic;

namespace WebMobile.Models;

public partial class Funcao
{
    public int Id { get; set; }

    public string Funcao1 { get; set; } = null!;

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
