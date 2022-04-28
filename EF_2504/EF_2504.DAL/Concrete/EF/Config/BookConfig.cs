using EF_2504.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_2504.DAL.Concrete.EF.Config
{
   public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => b.BookId);
            builder.Property(b => b.BookName).IsRequired();
            builder.Property(b => b.BookPrice).HasDefaultValue(0) ;
            builder.Property(b => b.BookCreatedDate).HasDefaultValue(DateTime.Now);
            builder.HasOne(b => b.Category)
                .WithMany(c => c.Books)
                .HasForeignKey(b => b.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasData(
                new Book { BookId = 1, BookName = "Yönetim Bilişm Sistemleri", BookImageUrl = "https://cdn.bkmkitap.com/yonetim-bilisim-sistemleri-ciltli-9200779-11-O.jpg", CategoryId = 1 },
                new Book { BookId = 2, BookName = "A'dan Z'ye Reset", BookImageUrl = "https://cdn.bkmkitap.com/adan-zye-php-3773727-41-O.jpg", CategoryId = 2 },
                new Book { BookId = 3, BookName = "Şampiyon Trabzonspor", BookImageUrl = "https://www.karadenizdesonnokta.com.tr/images/haberler/2021/10/dunyaca-unlu-site-trabzonspor-u-sampiyon-ilan-etti_f54a1.jpg", CategoryId = 3 }

                );

        }
    }
}
