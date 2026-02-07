-- 1. İngilizce Kelimeler Tablosu
CREATE TABLE IngilizceKelimeler (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Kelime NVARCHAR(100) NOT NULL,
    Anlami NVARCHAR(100),
    KullanimAlani NVARCHAR(MAX)
);

-- 2. Kod Terimleri Tablosu
CREATE TABLE KodTerimleri (
    ID INT PRIMARY KEY IDENTITY(1,1),
    KodAdi NVARCHAR(100) NOT NULL,
    Aciklama NVARCHAR(MAX),
    OrnekKod NVARCHAR(MAX)
);




