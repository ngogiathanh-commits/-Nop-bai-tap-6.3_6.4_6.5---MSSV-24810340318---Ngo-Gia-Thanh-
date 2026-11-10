CREATE DATABASE QLG;
GO

USE QLG;
GO

CREATE TABLE KhachHang (
        MaKH INT IDENTITY(1,1) PRIMARY KEY,
        TenKH NVARCHAR(100) NOT NULL,
        DienThoai VARCHAR(15) UNIQUE NOT NULL,
        DiaChi NVARCHAR(200)
);

CREATE TABLE Xe (
        BienSo VARCHAR(20) PRIMARY KEY,
        MaKH INT FOREIGN KEY REFERENCES KhachHang(MaKH) ON DELETE CASCADE,
        HieuXe NVARCHAR(50) NOT NULL,
        NamSanXuat INT
);

CREATE TABLE PhuTung (
        MaPhuTung INT IDENTITY(1,1) PRIMARY KEY,
        TenPhuTung NVARCHAR(150) NOT NULL,
        DonGia DECIMAL(18,2) NOT NULL CHECK (DonGia >= 0),
        SoLuongTon INT NOT NULL CHECK (SoLuongTon >= 0)
);

CREATE TABLE PhieuSuaChua (
        MaPhieu INT IDENTITY(1,1) PRIMARY KEY,
        BienSo VARCHAR(20) FOREIGN KEY REFERENCES Xe(BienSo),
        NgayNhan DATETIME DEFAULT GETDATE(),
        NoiDungSua NVARCHAR(MAX),
        TongTien DECIMAL(18,2) DEFAULT 0,
        TrangThai NVARCHAR(30) DEFAULT N'Đang sửa' -- 'Đang sửa', 'Đã hoàn thành', 'Đã thanh toán'
);

CREATE TABLE ChiTietSuaChua (
        MaPhieu INT FOREIGN KEY REFERENCES PhieuSuaChua(MaPhieu) ON DELETE CASCADE,
        MaPhuTung INT FOREIGN KEY REFERENCES PhuTung(MaPhuTung),
        SoLuong INT NOT NULL CHECK (SoLuong > 0),
        TienCong DECIMAL(18,2) DEFAULT 0 CHECK (TienCong >= 0),
        PRIMARY KEY (MaPhieu, MaPhuTung)
);

INSERT INTO KhachHang (TenKH, DienThoai, DiaChi) VALUES
    (N'Nguyễn Văn Hùng', '0912345678', N'123 Nguyễn Trãi, Hà Nội'),
    (N'Trần Thị Mai', '0987654321', N'456 Lý Thường Kiệt, TP.HCM');

INSERT INTO Xe (BienSo, MaKH, HieuXe, NamSanXuat) VALUES
    ('30A-12345', 1, 'Toyota Camy', 2020),
    ('51H-99999', 2, 'VinFast VF8', 2023);

INSERT INTO PhuTung (TenPhuTung, DonGia, SoLuongTon) VALUES
    (N'Lọc gió động cơ', 250000, 50),
    (N'Má phanh trước', 850000, 20),
    (N'Bugi Iridium', 180000, 100),
    (N'Dầu máy Synthetic 4L', 650000, 30),
    (N'Gạt mưa Silicon', 300000, 15);
GO