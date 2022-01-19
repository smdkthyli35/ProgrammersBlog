using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IArticleDal Articles { get; }
        ICategoryDal Categories { get; }
        ICommentDal Comments { get; }
        Task<int> SaveAsync();
    }
}
