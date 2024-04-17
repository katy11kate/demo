using System;
using System.Collections.Generic;

namespace ООО_Техносервис.Model;

public partial class Post
{
    public int Idpost { get; set; }

    public string? NamePost { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
