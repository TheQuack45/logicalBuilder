using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicalBuilder
{
    class OrGate: LogicGate
    {
        public OrGate(LogicGate InputA, LogicGate InputB, LogicGate Output) : base("OrGate",
            new Dictionary<bool[], bool[]>()
            {
                {new bool[2] {false, false}, new bool[1] {false}},
                {new bool[2] {false, true}, new bool[1] {true}},
                {new bool[2] {true, false}, new bool[1] {true}},
                {new bool[2] {true, true}, new bool[1] {true}},
            })
        {
            this.InputA = InputA;
            this.InputB = InputB;
            this.Output = Output;
        }
    }
}
