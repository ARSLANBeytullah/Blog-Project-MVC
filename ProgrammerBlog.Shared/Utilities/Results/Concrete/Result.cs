using ProgrammersBlog.Shared.Utilities.Results.Abstract;
using ProgrammersBlog.Shared.Utilities.Results.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Shared.Utilities.Results.Concrete
{
    public class Result : IResult
    {
        public Result(ResultStatus resultStatus)
        {   
            ResultStatus = resultStatus;
        }
        public Result(ResultStatus resultStatus, string message) //Mesela "Makale başarılı bir şekilde eklenmiştir" diye bir mesajın dönmesini istiyorsak bu constructor'a ihtiyaç duyuyoruz.
        {
            ResultStatus = resultStatus;
            Message = message;
        }
        public Result(ResultStatus resultStatus, string message,Exception exception)  
        {
            ResultStatus = resultStatus;
            Message = message;
            Exception = exception;
        }
        public ResultStatus ResultStatus { get; }  
        public string Message { get; }
        public Exception Exception { get; }
        //Kullanım örneği : new Result(ResultStatus.Error,"Ekleme işlemi başarısız oldu",exception); veya new Result(ResultStatus.Success,"Ürün başarılı bir şekilde eklendi",Exception);
        //Kullanım örneği : new Result (ResultStatus.Error,exception.message,exception);
    }
}
