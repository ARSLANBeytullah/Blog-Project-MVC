using ProgrammersBlog.Data.Abstract;
using ProgrammersBlog.Data.Concrete.EntityFramework.Contexts;
using ProgrammersBlog.Data.Concrete.EntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Data.Concrete
{
    
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ProgrammersBlogContext _context;
        private EfArticleRepository _articleRepository;
        private EfCategoryRepository _categoryRepository;
        private EfCommentRepository _commentRepository;
        private EfRoleRepository _roleRepository;
        private EfUserRepository _userRepository;

        public UnitOfWork(ProgrammersBlogContext context)
        {
            _context = context;
        }

        public IArticleRepository Articles => _articleRepository ?? new EfArticleRepository(_context); //Birisi bizden IArticleRepository isterse biz _articleRepository'i return edeceğiz. Bunu da lambda expression(=>) ile yapıyoruz.
                                                                                                       //eğer _articleRepository null ise veya yoksa(new'lenmemiş ise)  kullanıcıya EfArticle repositoryiyi newleyerek gönderiyoruz.(?? new EfArticleRepository)
        public ICategoryRepository Categories => _categoryRepository ?? new EfCategoryRepository(_context);

        public ICommentRepository Comments => _commentRepository ?? new EfCommentRepository(_context);

        public IRoleRepository Roles => _roleRepository ?? new EfRoleRepository(_context);

        public IUserRepository Users => _userRepository ?? new EfUserRepository(_context);

        public async ValueTask DisposeAsync() //Burada Context'imizi dispose ediyor olacağız.
        {
            await _context.DisposeAsync();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync(); //SaveChanges methodu integer değer döner !
        }
    }
}
