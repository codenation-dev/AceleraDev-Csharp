using System;
using System.Collections.Generic;
using System.Text;

namespace ModificadorAcesso
{
    public class ClassePublica
    {
        public int MinhaPropPublica { get; set; }
        private int MinhaPropPrivada { get; set; }
        protected int MinhaPropProtected { get; set; }
        internal int MinhaPropInternal { get; set; }
        protected internal int MinhaPropProtectedInternal { get; set; }
        private protected int MinhaPropPrivateProtected { get; set; }
    }
}
