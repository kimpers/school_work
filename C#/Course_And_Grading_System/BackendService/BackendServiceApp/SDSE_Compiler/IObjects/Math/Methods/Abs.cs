﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;

namespace Compiler
{
    class Abs : IObject
    {
        public Abs()
        {
        }

        public override IObject MethodOperator(IObject[] strParams)
        {
            if (strParams.Length == 1)
            {
                double value = Compiler.I_Number.ToDouble(strParams[0]);
                return new I_Float(Math.Abs(value));
            }
            return new I_Error("Wrong number of arguments.");
        }

        public override int GetAutoCompleteIconIndex() { return 4; }
        public override string GetAutoCompleteToolTip(string str) { return str + "(Number value)"; }
        public override string GetAutoCompleteText(string str) { return str; }
        public override string GetAutoCompleteListText(string str) { return str + "()"; }
    }
}
