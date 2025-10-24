create database HoangQuocAnh_231230703_de02
use HoangQuocAnh_231230703_de02

create table HqaCatalog(
	hqaId nvarchar(10) primary key,
	hqaCateName nvarchar(50),
	hqaCatePrice decimal,
	hqaCateQty int,
	hqaPicture nvarchar(max),
	hqaCateActive bit

);
-- 2. Insert 3 sample records
INSERT INTO HqaCatalog (hqaId, hqaCateName, hqaCatePrice, hqaCateQty, hqaPicture, hqaCateActive) VALUES
('HQA001', N'Điện thoại thông minh', 15500000.00, 50, NULL, 1),
('HQA002', N'Máy tính xách tay', 22750000.50, 35, Null, 1),
('HQA003', N'Tai nghe không dây', 1800000.00, 120, Null, 0);

select *from HqaCatalog
DELETE FROM HqaCatalog;

