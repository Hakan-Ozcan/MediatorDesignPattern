using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern
{
    public interface IAirTrafficControlMediator
    {
        void Notify(Airplane airplane, string message);
        void RequestLanding(Airplane airplane);
    }
}
