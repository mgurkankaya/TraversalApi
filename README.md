# Traversal API

Bu proje, ziyaretçileri yönetmek için bir ASP.NET Core API uygulamasıdır. CRUD (Create, Read, Update, Delete) işlemlerini gerçekleştirmek için bir VisitorController yapılandırılmıştır.

## 🚀 Özellikler

- Ziyaretçilerin Listelenmesi (GET /api/Visitor)
- Yeni Ziyaretçi Eklenmesi (POST /api/Visitor)
- Belirli Bir Ziyaretçinin Detaylarının Getirilmesi (GET /api/Visitor/{id})
- Ziyaretçinin Silinmesi (DELETE /api/Visitor/{id})
- Mevcut Bir Ziyaretçinin Güncellenmesi (PUT /api/Visitor)
  
## 📂 Kullanılan Teknolojiler
ASP.NET Core 7.0: Web API oluşturmak için.
Entity Framework Core: Veri tabanı işlemleri için.
CORS Desteği: Farklı kaynaklardan erişime izin vermek için EnableCors kullanılmıştır
