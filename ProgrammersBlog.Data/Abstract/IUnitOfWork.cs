using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Data.Abstract
{
    public interface IUnitOfWork:IAsyncDisposable //Unit Of Work yapısı sayesin de bütün repositorylerimizi tek bir noktada yönetme imkanımız olacak.
    {
        IArticleRepository Articles { get; } // unitofwork.Articles diyerek makalemize erişebiliyor olacağız.
        ICategoryRepository Categories { get; }
        ICommentRepository Comments { get; }
        IRoleRepository Roles { get; }
        IUserRepository Users { get; } //_unitOfWork.Categories.AddAsync() diyerek metodumuzu kullanıyor olacağız.
        //_unitOfWork.Categories.AddAsync(category);
        //_unitOfWork.Users.AddAsync(user); //Örnek olarak bir kategori ve bir kullanıcı ekleme ve sonrasın da veri tabanına kaydetme 
        //_unitOfWork.SaveAsync();           olayını gerçekleştirilmesi bu şekilde olacaktır. Eğer kullanıcı eklerken veya kategori eklerken herhangi bir hata
                                  //ile karşılaşılırsa hiçbir şekilde SaveAsync() methodu çalışmayacak ve veri tabanın da hiçbir değişiklik meydana gelmeyecektir.
        Task<int> SaveAsync(); //Veri tabanın da birçok işlemi yaptıktan sonra yapılan değişikliklerin kayıt edilmesi için bu method tanımlandı.
        //dönüş tipi int çünkü bizler etkilenen kayıt sayısını almak isteyebiliriz.
    }
}
