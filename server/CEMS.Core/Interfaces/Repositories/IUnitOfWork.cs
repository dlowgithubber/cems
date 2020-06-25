using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CEMS.Core.Interfaces.Repositories
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
