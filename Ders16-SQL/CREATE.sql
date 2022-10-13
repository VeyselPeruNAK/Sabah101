 CREATE DATABASE OKUL_VT; -- OKUL_VT isminde bir veritabanı oluşturduk.

-- DROP DATABASE OKUL_VT; -- OKUL_VT veritabanını siler.

USE OKUL_VT; -- OKUL_VT veritabanını kullan.

-- Tablo oluşturuyoruz.

CREATE TABLE tb_Ogrenci 
(
	numara int,
	ad nvarchar(50),
	soyad nvarchar(50),
	dogumYili smallint,
	sinif varchar(5)
);

-- Tabloyu düzenliyoruz.

ALTER TABLE tb_Ogrenci ALTER COLUMN numara nvarchar(50) NOT NULL;
ALTER TABLE tb_Ogrenci ALTER COLUMN ad nvarchar(50) NOT NULL;
ALTER TABLE tb_Ogrenci  ALTER COLUMN soyad nvarchar(50) NOT NULL;
ALTER TABLE tb_Ogrenci  ALTER COLUMN dogumYili smallint NOT NULL;
ALTER TABLE tb_Ogrenci  ALTER COLUMN sinif varchar(5) NOT NULL;

-- nuamra yı primary key yaptık.
ALTER TABLE [dbo].[tb_Ogrenci] ADD  CONSTRAINT [PK_tb_Ogrenci] PRIMARY KEY CLUSTERED (	[numara] ASC)

ALTER TABLE tb_Ogrenci DROP CONSTRAINT  PK_tb_Ogrenci;
ALTER TABLE tb_Ogrenci DROP numara;
ALTER TABLE tb_Ogrenci ADD numara int NOT NULL IDENTITY(1,1) PRIMARY KEY;