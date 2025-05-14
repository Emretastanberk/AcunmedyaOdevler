create database Hasta_Randevu_Sistemi
use Hasta_Randevu_Sistemi

CREATE TABLE Branslar (
    Id INT PRIMARY KEY IDENTITY,
    BransAdi NVARCHAR(100)
);

CREATE TABLE Doktorlar (
    Id INT PRIMARY KEY IDENTITY,
    DoktorAdi NVARCHAR(100),
    DoktorSoyadi NVARCHAR(100),
    BransID INT FOREIGN KEY REFERENCES Branslar(Id)
);

CREATE TABLE Randevular (
    Id INT PRIMARY KEY IDENTITY,
    HastaAdi NVARCHAR(100),
    HastaSoyadi NVARCHAR(100),
    BransID INT FOREIGN KEY REFERENCES Branslar(Id),
    DoktorID INT FOREIGN KEY REFERENCES Doktorlar(Id),
    Tarih DATETIME
);
