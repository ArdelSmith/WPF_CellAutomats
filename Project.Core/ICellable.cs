using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core
{
    internal interface ICellable
    {
        Type GetCellType();
        void SetCellType(Type type);
        CellStatus GetCellStatus();
        void SetCellStatus(CellStatus cellStatus = CellStatus.Dead);
        int GetCellsNearby();
        void SetCellsNearby(int amount);


    }
}
