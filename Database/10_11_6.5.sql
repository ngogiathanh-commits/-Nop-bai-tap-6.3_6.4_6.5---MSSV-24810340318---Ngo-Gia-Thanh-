CREATE DATABASE QLK;
GO

USE QLK;
GO

CREATE TABLE PhongHat (
        MaPhong INT IDENTITY(1,1) PRIMARY KEY,
        TenPhong NVARCHAR(50) NOT NULL,
        LoaiPhong NVARCHAR(30) DEFAULT N'Thường',
        GiaTheoGio DECIMAL(18,2) NOT NULL CHECK (GiaTheoGio > 0),
        TrangThai NVARCHAR(20) DEFAULT N'Trống' 
);

CREATE TABLE DichVu (
        MaDV INT IDENTITY(1,1) PRIMARY KEY,
        TenDV NVARCHAR(100) NOT NULL,
        DonGia DECIMAL(18,2) NOT NULL CHECK (DonGia >= 0),
        TonKho INT NOT NULL CHECK (TonKho >= 0)
);

CREATE TABLE HoaDon (
        MaHD INT IDENTITY(1,1) PRIMARY KEY,
        MaPhong INT FOREIGN KEY REFERENCES PhongHat(MaPhong),
        GioVao DATETIME NOT NULL DEFAULT GETDATE(),
        GioRa DATETIME NULL,
        TongTienPhong DECIMAL(18,2) DEFAULT 0,
        TongTienDichVu DECIMAL(18,2) DEFAULT 0,
        TrangThai BIT DEFAULT 0 
);

CREATE TABLE ChiTietDichVu (
        MaHD INT FOREIGN KEY REFERENCES HoaDon(MaHD) ON DELETE CASCADE,
        MaDV INT FOREIGN KEY REFERENCES DichVu(MaDV),
        SoLuong INT NOT NULL CHECK (SoLuong > 0),
        DonGia DECIMAL(18,2) NOT NULL CHECK (DonGia >= 0),
        PRIMARY KEY (MaHD, MaDV)
);

INSERT INTO PhongHat (TenPhong, LoaiPhong, GiaTheoGio, TrangThai) VALUES
    (N'Phòng VIP 01', N'VIP', 180000, N'Trống'),
    (N'Phòng VIP 02', N'VIP', 180000, N'Trống'),
    (N'Phòng Thường 01', N'Thường', 100000, N'Trống'),
    (N'Phòng Thường 02', N'Thường', 100000, N'Trống'),
    (N'Phòng Thường 03', N'Thường', 100000, N'Trống');

INSERT INTO DichVu (TenDV, DonGia, TonKho) VALUES
    (N'Bia Heineken (Lon)', 25000, 200),
    (N'Bia Tiger (Lon)', 22000, 300),
    (N'Trái cây dĩa lớn', 120000, 50),
    (N'Nước suối Aquafina', 15000, 150),
    (N'Mực khô nướng', 150000, 30);
GO
