# LinqGroupJoin
# Öğrenci ve Sınıf Gruplama Uygulaması

Bu proje, öğrenci ve sınıf verilerini kullanarak Group Join fonksiyonelliğini uygulayan basit bir C# programıdır.
Programda, her sınıfın öğrencileriyle ilişkisini gruplandırarak ekrana yazdırmaktadır.

## Kullanılan Teknolojiler
C#
LINQ (Language Integrated Query)
.NET Framework

## Özellikler
Öğrenciler ve sınıflar arasında ilişki kurmak için LINQ Group Join kullanılmıştır.
Öğrenciler, kendi sınıflarına göre gruplanarak ekrana yazdırılmıştır.
Öğrenciler ve sınıflar arasındaki ilişki, sınıf ID'sine göre yapılmıştır.

## Kurulum ve Çalıştırma
Bu projeyi bilgisayarınıza indirin veya bir C# projesi oluşturun.
Visual Studio veya başka bir C# geliştirme ortamında projeyi açın.
Programı çalıştırarak sınıflara ait öğrencilerin sırasını görebilirsiniz.

## Kod Açıklaması
Student Sınıfı:

StudentId: Öğrencinin benzersiz kimliği.
StudentName: Öğrencinin adı.
ClassId: Öğrencinin hangi sınıfa ait olduğunu belirten sınıf kimliği.
Class Sınıfı:

ClassId: Sınıfın benzersiz kimliği.
ClassName: Sınıfın adı (örneğin Matematik, Türkçe, Kimya).
Main Fonksiyonu:

Öğrenciler ve sınıflar listesini oluşturur.
LINQ Group Join sorgusu ile öğrencileri kendi sınıflarına göre gruplayarak sonuçları yazdırır.
