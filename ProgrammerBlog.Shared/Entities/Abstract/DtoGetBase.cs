using ProgrammersBlog.Shared.Utilities.Results.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Shared.Entities.Abstract
{
    public abstract class DtoGetBase //Get işlemleri için Dto'ların base sınıfı oluşturduk.Override edilebilmesi için class abstract ile işaretlendi
    {
        public virtual ResultStatus ResultStatus { get; set; } //virtual olarak işaretlendiği için override edilebilir oldu. 
    }
}
