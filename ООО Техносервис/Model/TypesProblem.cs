using System;
using System.Collections.Generic;

namespace ООО_Техносервис.Model;

public partial class TypesProblem
{
    public int IdtypesProblem { get; set; }

    public string? NameProblem { get; set; }

    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();
}
