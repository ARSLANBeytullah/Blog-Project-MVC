using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Shared.Utilities.Results.Abstract
{
    public interface IDataResult<out T>:IResult  //Burada generic yapısı yapılmalı ve tip tek başına T olarak verilmemeli.Örnek olarak bir kategori tek başına taşınmak istenebileceği gibi IList veya INumarable olarak da taşınmak istenebilir.Yani istersek tek bir entity istersek de bir liste taşımak için bu şekilde <out T> yapıyoruz.
    {
        public T Data { get;} //new DataResult<Category>(ResultStatus.Success,category);
                              //new DataResult<IList<Category>>(ResultStatus.Success,categoryList);
    }
}
