using System;
using System.Collections.Generic;

namespace AppCrud.Models;

public partial class Auto
{
    public Guid Id { get; set; }

    public string Marca { get; set; } = null!;

    public string Modelo { get; set; } = null!;

    public int Anio { get; set; }

    public string TipoAuto { get; set; } = null!;

    public int CantidadAsientos { get; set; }

    public string? Color { get; set; }

    public string? Descripcion { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
