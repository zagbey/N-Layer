using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T>GetByIdAsync(int id);
        IQueryable<T> GetAll();

        //productRepository.where(x=>x.id>5).OrderBy.ToListAsync();
        IQueryable<T> Where(Expression<Func<T,bool>> expression);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);

        //update ve delete EFcore tarafında sürekli takip edildiği için stati modified oalrak değişiyor yani memoryde bir Async durum yok 
        void Update(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
