using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ritu_AKQA_Code.Models;

namespace Ritu_AKQA_Code.Repository
{
    public interface IPersonRepository
    {
        Person GetPerson(Person person);
    }
}
