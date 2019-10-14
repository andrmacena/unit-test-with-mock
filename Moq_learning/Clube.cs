using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moq_learning
{
    public class Clube
    {
        private readonly ISocio _socio;

        public Clube(ISocio socio)
        {
            this._socio = socio;
        }

        public double CalcularFrete(int socioID)
        {
            if (socioID > 0)
            {
                double socioValorFrete = 0;
                Socio socio = _socio.GetSocio(socioID);
                socioValorFrete = 10 + socio.Limite * 0.8;
                return socioValorFrete;
            }
            else
            {
                return -1;
            }
        }
    }
}