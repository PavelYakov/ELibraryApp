CREATE TABLE Divisions (
    ID INT PRIMARY KEY not null,
    NameDivision VARCHAR(100)NOT NULL,
	ParentDivisionsID INT,
	FOREIGN KEY (ParentDivisionsID) REFERENCES Divisions(ID)
);

CREATE TABLE Employees (
    ID INT PRIMARY KEY not null,
    FirstName VARCHAR(100),
FatherName VARCHAR(100),
LastName VARCHAR(100),
    TabelNubmer INT,
    DivisionID INT not null,
    FOREIGN KEY (DivisionID) REFERENCES Divisions(ID)
);

Insert into Divisions (ID, NameDivision, ParentDivisionsID)
values (1,'customer service',NUll),
(2, 'department sales',1),
(3, 'department wholesale department',2),
(4, 'Retail Sales Department',2),
(5, 'Logistics Department',1),
(6,'Warehouse',5),
(7, 'Delivery Department',5),
(8, 'Production Department',null),
(9, 'Engineering Department',8),
(10,'Quality Control Department',8),
(11,' Purchasing Department',8),
(12,'Accounting',null);

Insert into Employees (ID,FirstName,FatherName,LastName,TabelNubmer,DivisionID)
values (1,'Igor','Mihalych','Opolko',1234,1),
(2,'Stasislav','Olegovuch','Pilipchuk',4567,2),
(3,'Vladislav','Urich','Soroka',1235,3),
(4,'Evgeny','Urich','Kylinka',1223,3),
(5,'Uriy','pavlivich','Gruboedov',2234,4),
(6,'Pavel','Anatolych','Trutko',4456,4),
(7,'Michail','Olegovich','Pahanc',4445,5),
(8,'Artyr','Pavlovich','Idchitc',5556,6),
(9,'Uriy','Victorovich','Kovalevich',7676,6),
(10,'Maksim','Urich','Shik',8890,7),
(11,'Oleg','Igirevich','Sevostey',7612,8),
(12,'Viktor','Urich','Kazimirchuk',3231,8),
(13,'Janna','Arkadyevna','Tychukova',4455,9),
(14,'Anastasiya','Pavlovna','Lanec',6677,10),
(15,'Egor','Pavlovich','Buzyma',7878,10),
(16,'Viktor','Mihalych','Shkred',8787,11),
(17,'Pavel','Olegovich','Jukovich',9991,12);
