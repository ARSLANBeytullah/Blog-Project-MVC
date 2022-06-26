using ProgrammersBlog.Shared.Utilities.Results.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Shared.Utilities.Results.Abstract
{
    public interface IResult
    {  //ResultStatus veri tipi ConplexType klasöründe tanımlandı.
        public ResultStatus ResultStatus { get;} //Şu şekilde kullanılacak : ResultStatus.Success veya ResultStatus.Error
        public string Message { get;}
        public Exception Exception{ get;}

    }
}
