using System;
using System.Collections.Generic;

namespace ООО_Техносервис.Model;

public partial class Request
{
    public int IdRequest { get; set; }

    public DateTime DateAdd { get; set; }

    public string Device { get; set; } = null!;

    public int TypeProblem { get; set; }

    public int Client { get; set; }

    public string? DescriptionProblem { get; set; }

    public int Status { get; set; }

    public DateTime? DateEnd { get; set; }

    public int? ResponsibleEmployee { get; set; }

    public virtual Client ClientNavigation { get; set; } = null!;

    public virtual ICollection<Coment> Coments { get; set; } = new List<Coment>();

    public virtual Employee? ResponsibleEmployeeNavigation { get; set; }

    public virtual Status StatusNavigation { get; set; } = null!;

    public virtual TypesProblem TypeProblemNavigation { get; set; } = null!;
}
