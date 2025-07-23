🧑‍💻 Code First İlişkisel Veri Tabanı – EF Core
Bu proje, Entity Framework Core ile Code First yaklaşımını kullanarak ilişkili tablolar içeren bir veri tabanı oluşturur.

🗃️ Veri Tabanı Yapısı – PatikaCodeFirstDb2
👤 User Tablosu (Users)
Id (int): Birincil anahtar

Username (string): Kullanıcı adı

Email (string): E-posta adresi

📝 Post Tablosu (Posts)
Id (int): Birincil anahtar

Title (string): Gönderi başlığı

Content (string): Gönderi içeriği

UserId (int): İlişkili kullanıcı ID’si (foreign key)

✔️ İlişki: Bir User birden çok Post'a sahip olabilir. Her Post yalnızca bir User'a bağlıdır.

🧠 DbContext
Sınıf Adı: PatikaSecondDbContext

Tablolar: Users, Posts

Veritabanı: PatikaCodeFirstDb2

