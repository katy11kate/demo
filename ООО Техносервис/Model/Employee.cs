using System;
using System.Collections.Generic;

namespace ООО_Техносервис.Model;

public partial class Employee
{
    public int Idemployee { get; set; }

    public string? Firstname { get; set; }

    public string? Name { get; set; }

    public string? Patronymic { get; set; }

    public string? Login { get; set; }

    public string? Password { get; set; }

    public int? Post { get; set; }

    public virtual ICollection<Coment> Coments { get; set; } = new List<Coment>();

    public virtual Post? PostNavigation { get; set; }

    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();
}
