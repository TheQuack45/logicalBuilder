using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicalBuilder
{
    class LogicGate
    {
        // Fields and properties
        private string _Name;
        public string Name
        {
            get { return _Name; }
        }

        private LogicGate _InputA;
        public LogicGate InputA
        {
            get { return _InputA; }
            set { _InputA = value; }
        }

        private LogicGate _InputB;
        public LogicGate InputB
        {
            get { return _InputB; }
            set { _InputB = value; }
        }

        private LogicGate _Output;
        public LogicGate Output
        {
            get { return _Output; }
            set { _Output = value; }
        }

        private Dictionary<bool[], bool[]> _TruthTable;
        public Dictionary<bool[], bool[]> TruthTable
        {
            get { return _TruthTable; }
        }

        // Constructors
        public LogicGate(string Name, LogicGate InputA, LogicGate InputB, LogicGate Output, Dictionary<bool[], bool[]> TruthTable)
        {
            this._Name = Name;
            this._InputA = InputA;
            this._InputB = InputB;
            this._Output = Output;
            this._TruthTable = TruthTable;
        }

        public LogicGate(string Name, Dictionary<bool[], bool[]> TruthTable)
        {
            this._Name = Name;
            this._TruthTable = TruthTable;
        }
    }
}
