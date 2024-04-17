using System;
using System.Collections.Generic;

namespace ООО_Техносервис.Model;

public partial class Status
{
    public int Idstatus { get; set; }

    public string? NameStatus { get; set; }

    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();
}
