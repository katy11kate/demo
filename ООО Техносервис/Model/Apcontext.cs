using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООО_Техносервис.Model
{
    public partial class Apcontext
    {
        public static Model.OooTachnoserviceContext Context { get; } = new Model.OooTachnoserviceContext();
        public static string Name { get; set; }
        public static int Id { get; set; }
        private static int p = 0;
        public static int EnvironmentVariableTarget
        {
            get { return p; }
            set { p = value; }
        }
    }
}
