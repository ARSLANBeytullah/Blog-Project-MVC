using ProgrammersBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Entities.Dtos
{
    public class ArticleAddDto //Kullanıcının makale ile ilgili bizlere verebileceği bilgileri eklememiz gerekiyor.
    {
        [DisplayName("Başlık")]   //Data annotation //Burada son kullancıya Title değil de Başlık olarak görünmesini istediğimizden DisplayName[("Başlık")] yazdık.
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MaxLength(100,ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır")]
        [MinLength(5,ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır")] //Title alanı ile ilgili attribute'lerimizi yani Data Annotation'larımızı eklemiş olduk.
        public string Title { get; set; }
        [DisplayName("İçerik")]    
        [MaxLength(ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır")]
        [MinLength(20, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır")]
        public string Content { get; set; }
        [DisplayName("Thumbnail")]   
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MaxLength(250, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır")]
        [MinLength(5, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır")]
        public string Thumbnail { get; set; }
        [DisplayName("Tarih")]   
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }
        [DisplayName("Seo Yazar")]   
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MaxLength(50, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır")]
        [MinLength(0, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır")]
        public string SeoAuthor { get; set; }
        [DisplayName("Seo Açıklama")]   
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MaxLength(150, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır")]
        [MinLength(0, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır")]
        public string SeoDescription { get; set; }
        [DisplayName("Seo Etiketler")]   
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MaxLength(70, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır")]
        [MinLength(0, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır")]
        public string SeoTags { get; set; }
        [DisplayName("Kategori")]   
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]  
        public int CategorId { get; set; }
        public Category Category { get; set; } //Navigation Property
        [DisplayName("Aktif mi?")]   //Data annotation 
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        public bool IsActive { get; set; }
    }
}
