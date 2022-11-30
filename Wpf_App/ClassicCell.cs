using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace huyna
{
    public class ClassicCell : ACell
    {
        Type type = Type.Classic_Cell;
        public ClassicCell()
        {
            this.SetCellStatus();
        }
    }
}
