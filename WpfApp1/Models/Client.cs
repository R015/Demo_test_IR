using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Data;

namespace WpfApp1.Data
{
    public partial class Client
    {
        public DateTime? LastDate { get; set; }
        public int CountDate { get => MainWindow.HermesDB.Visit.Where(x => x.ClientId == this.Id).Count() ; set { } }
    }
}
