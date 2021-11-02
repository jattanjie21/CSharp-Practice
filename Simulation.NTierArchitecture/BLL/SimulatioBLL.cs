using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation.NTierArchitecture.BLL
{
    public class Simulation
    {
        SimulationDAL simulationDAL = new SimulationDAL();

        public int CreateNewUser()
        {
            return simulationDAL.CreateNewUser();
        }
    }
}
