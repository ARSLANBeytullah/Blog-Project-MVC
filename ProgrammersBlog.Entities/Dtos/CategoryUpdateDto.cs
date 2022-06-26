using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Entities.Dtos
{
    public class CategoryUpdateDto
    {
        //Data Annotation özellikleri
        [Required]
        public int Id { get; set; }
        [DisplayName("Kategori Adı")] //Name alanının eklendiği yerde Kategori Adı görünmesini sağlar.
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")] //Kategori Adı Boş Geçilemez yazacaktır.
        [MaxLength(70, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır.")] //Kategori Adı 70 karakterden büyük olamaz yazar.
        [MinLength(3, ErrorMessage = "{0} {1} karakterden az olmamalıdır.")]
        public string Name { get; set; }
        [DisplayName("Kategori Açıklaması")]
        [MaxLength(500, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır.")]
        [MinLength(3, ErrorMessage = "{0} {1} karakterden az olmamalıdır.")]
        public string Description { get; set; }
        [DisplayName("Kategori Özel Not Alanı")]
        [MaxLength(500, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır.")]
        [MinLength(3, ErrorMessage = "{0} {1} karakterden az olmamalıdır.")]
        public string Note { get; set; }
        [DisplayName("Aktif Mi ?")]  //check box şeklin de kullanıcıya aktif mi ? pasif mi ? diye sorulacak.
        [Required(ErrorMessage = "{0} Boş geçilmemelidir.")]
        public bool IsActive { get; set; }
        [DisplayName("Silindi Mi ?")]  //check box şeklin de kullanıcıya aktif mi ? pasif mi ? diye sorulacak.
        [Required(ErrorMessage = "{0} Boş geçilmemelidir.")]
        public bool IsDeleted { get; set; }
    }
}
