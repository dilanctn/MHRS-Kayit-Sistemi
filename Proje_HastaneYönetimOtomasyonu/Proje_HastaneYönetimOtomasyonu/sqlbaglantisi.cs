using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//verileri çekmek ve sql ile bağlantı kurmak için

namespace Proje_HastaneYönetimOtomasyonu
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()//baglanti adında bir metot oluşturdum
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-7C53G4M\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True");
            //baglan = sqlconnection sınıfından türetiğim ve baglantı adresimi tutan nesnenin adı
            baglan.Open();
            return baglan;
        }
    }
}
