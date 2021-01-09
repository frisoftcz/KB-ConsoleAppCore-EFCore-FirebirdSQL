using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB_ConsoleAppCore_EFCore_FirebirdSQL.Model
{
  public class EntFyzOsoba
  {
    public string ID { get; set; }
    public DateTime DATETIME { get; set; }
    public string LOGIN { get; set; }
    public string OSOBATYP_ID { get; set; }
    public string FYZOSOBA_PRIJMENI { get; set; }
    public string FYZOSOBA_JMENO { get; set; }
    public DateTime? FYZOSOBA_DAT_NAR { get; set; }
    public string POZNAMKA { get; set; }
  }
}
