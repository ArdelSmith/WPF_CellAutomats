using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core
{
    public abstract class ACell : ICellable
    {
        private Type type;
        private CellStatus status;
        private int CellsNearby;
        public Type GetCellType()
        {
            return this.type;
        }
        public void SetCellType(Type type)
        {
            this.type = type;
        }
        public virtual int GetCellsNearby()
        {
            return this.CellsNearby;
        }
        public virtual void SetCellsNearby(int amount)
        {
            if (amount > 0 && amount <= 8) this.CellsNearby = amount;
            else this.CellsNearby = 0;
        }
        public virtual CellStatus GetCellStatus()
        {
            return this.status;
        }
        public virtual void SetCellStatus(CellStatus status = CellStatus.Dead)
        {
            this.status = status;
        }
    }
}
