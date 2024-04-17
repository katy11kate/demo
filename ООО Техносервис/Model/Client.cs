using System;
using System.Collections.Generic;

namespace ООО_Техносервис.Model;

public partial class Client
{
    public int Idclient { get; set; }

    public string Firstname { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Patronymic { get; set; }

    public string Telephone { get; set; } = null!;

    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();
}
