﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES.RPP
{
    public class BancoProvincial : BancoNacional
    {
        public string provincia;

        public BancoProvincial(BancoNacional bn, string provincia)
            : base(bn.nombre, bn.pais)
        {
            this.provincia = provincia;
        }

        public override string Mostrar()
        {
            return "Banco Provincial";
        }
    }
}
