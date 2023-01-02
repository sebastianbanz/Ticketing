using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticketing.Models;

namespace DbDomain.Interfaces
{
    public interface IIndividual
    {
        IEnumerable<Individual> GetIndividual(int id);

        void AddIndividual(string Fname);
    }
}
