CREATE DATABASE QLPT;
go

USE QLPT;
go

CREATE TABLE DuAn (
        MaDuAn INT IDENTITY(1,1) PRIMARY KEY,
        TenDuAn NVARCHAR(150) NOT NULL,
        NgayBatDau DATETIME NOT NULL,
        NgayKetThuc DATETIME NOT NULL,
        TrangThai NVARCHAR(50) DEFAULT N'Đang chạy' 
);

CREATE TABLE ThanhVien (
        MaThanhVien INT IDENTITY(1,1) PRIMARY KEY,
        HoTen NVARCHAR(100) NOT NULL,
        Email VARCHAR(100) UNIQUE NOT NULL,
        ChuyenMon NVARCHAR(100)
);

CREATE TABLE CongViec (
        MaTask INT IDENTITY(1,1) PRIMARY KEY,
        MaDuAn INT FOREIGN KEY REFERENCES DuAn(MaDuAn) ON DELETE CASCADE,
        TenTask NVARCHAR(200) NOT NULL,
        MoTa NVARCHAR(MAX),
        HanNop DATETIME NOT NULL,
        DoUuTien NVARCHAR(20) DEFAULT N'Trung bình', 
        TrangThai NVARCHAR(50) DEFAULT N'To Do'     
);

CREATE TABLE PhanCong (
        MaTask INT FOREIGN KEY REFERENCES CongViec(MaTask) ON DELETE CASCADE,
        MaThanhVien INT FOREIGN KEY REFERENCES ThanhVien(MaThanhVien) ON DELETE CASCADE,
        NgayGiao DATETIME DEFAULT GETDATE(),
        PRIMARY KEY (MaTask, MaThanhVien)
);

INSERT INTO DuAn (TenDuAn, NgayBatDau, NgayKetThuc, TrangThai) VALUES
    (N'Hệ thống ERP Doanh Nghiệp', '2026-01-01', '2026-12-31', N'Đang chạy'),
    (N'Ứng dụng Mobile Banking', '2026-03-01', '2026-09-30', N'Đang chạy');

INSERT INTO ThanhVien (HoTen, Email, ChuyenMon) VALUES
    (N'Nguyễn Văn A', 'anguyen@gmail.com', N'Backend Developer'),
    (N'Trần Thị B', 'btran@gmail.com', N'Frontend Developer'),
    (N'Lê Hoàng C', 'cle@gmail.com', N'Tester & QA');

INSERT INTO CongViec (MaDuAn, TenTask, MoTa, HanNop, DoUuTien, TrangThai) VALUES
    (1, N'Thiết kế CSDL SQL Server', N'Tạo các bảng và chuẩn hóa 3NF', '2026-02-15', N'Cao', N'Done'),
    (1, N'Viết API Đăng nhập & Phân quyền', N'Dùng JWT và OAuth2', '2026-03-01', N'Cao', N'In Progress'),
    (1, N'Kiểm thử hiệu năng Database', N'Stress test 10,000 req/s', '2026-02-01', N'Trung bình', N'To Do');

INSERT INTO PhanCong (MaTask, MaThanhVien) VALUES
    (1, 1),
    (2, 1), (2, 2),
    (3, 3);
go