using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes.Commands
{
    internal class CeilingFanHighCommand : Command
    {
        CeilingFan ceilingFan;
        int prevSpeed;
        public CeilingFanHighCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            this.prevSpeed = ceilingFan.GetSpeed();
            ceilingFan.High();
        }

        public void Undo()
        {
            switch (prevSpeed)
            {
                case 0:
                    {
                        this.ceilingFan.Off();
                        break;
                    }
                case 1:
                    {
                        this.ceilingFan.Low();
                        break;
                    }
                case 2:
                    {
                        this.ceilingFan.Medium();
                        break;
                    }
                case 3:
                    {
                        this.ceilingFan.High();
                        break;
                    }
            }
        }
    }
}
