using System;
using System.Collections.Generic;

namespace ООО_Техносервис.Model;

public partial class Coment
{
    public int Idcoments { get; set; }

    public string TextComenrs { get; set; } = null!;

    public int IdEmployee { get; set; }

    public int IdRequest { get; set; }

    public virtual Employee IdEmployeeNavigation { get; set; } = null!;

    public virtual Request IdRequestNavigation { get; set; } = null!;
}
