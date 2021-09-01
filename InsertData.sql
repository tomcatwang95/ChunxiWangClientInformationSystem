USE ClientSystem
Go
SET IDENTITY_INSERT Employees ON
INSERT INTO Employees (Id, Name, Password, Designation)
VALUES(1, 'David Wang', 'abc123!!', 'Chief Executive Officer');
INSERT INTO Employees (Id, Name, Password, Designation)
VALUES(2, 'Chunxi Zhang', 'abc456!!', 'Chief Operating Officer');
INSERT INTO Employees (Id, Name, Password, Designation)
VALUES(3, 'Kefu Wu', 'abc789!!', 'Chief Financial Officer');
INSERT INTO Employees (Id, Name, Password, Designation)
VALUES(4, 'Lin Wu', 'bcd123!!', 'Chief Marketing Officer');
INSERT INTO Employees (Id, Name, Password, Designation)
VALUES(5, 'Jinbo Wang', 'efg123!!', 'Chief Marketing Officer');
INSERT INTO Employees (Id, Name, Password, Designation)
VALUES(6, 'Hongsen Wang', 'efg456!!', 'Chief Marketing Officer');
INSERT INTO Employees (Id, Name, Password, Designation)
VALUES(7, 'Shihao Qu', 'efg789!!', 'Chief Technology Officer');
INSERT INTO Employees (Id, Name, Password, Designation)
VALUES(8, 'Kobe Wang', 'python3!!!', 'Chief Technology Officer');
INSERT INTO Employees (Id, Name, Password, Designation)
VALUES(9, 'Sifan Dong', 'css567!', 'Chief Technology Officer');
INSERT INTO Employees (Id, Name, Password, Designation)
VALUES(10, 'Leo Wang', 'cis123!!', 'Chief Technology Officer'); --g
INSERT INTO Employees (Id, Name, Password, Designation)
VALUES(11, 'Che Shuo', 'cheshui51!', 'President');--g
INSERT INTO Employees (Id, Name, Password, Designation)
VALUES(12, 'Dingfan Xing', 'caicai23!!', 'Vice President');
INSERT INTO Employees (Id, Name, Password, Designation)
VALUES(13, 'Yuewei Li', 'uvw345!!', 'Vice President');
INSERT INTO Employees (Id, Name, Password, Designation)
VALUES(14, 'Yu Guan', 'xyz!!', 'Executive Assistant');
INSERT INTO Employees (Id, Name, Password, Designation)
VALUES(15, 'Yuchao Lu', 'pqr678!', 'Executive Assistant');
SET IDENTITY_INSERT Employees OFF
SELECT *
FROM Employees


SET IDENTITY_INSERT Clients ON
INSERT INTO Clients(Id, Name, Email, Phones, Address, AddedOn)
VALUES(1, 'Emmett Stewart', 'vummimmaudautreu-2529@yopmail.com', '608-831-5319', '9584 Studebaker Street Greensboro, NC 27405', '2000-09-01');
INSERT INTO Clients(Id, Name, Email, Phones, Address, AddedOn)
VALUES(2, 'Elizabeth Davis', 'procrauhehauqui-4854@yopmail.com', '308-248-9317', '7 Thatcher St. Bangor, ME 04401', '2000-09-14');
INSERT INTO Clients(Id, Name, Email, Phones, Address, AddedOn)
VALUES(3, 'Mason Houston', 'dekocillappa-8711@yopmail.com', '414-384-6709', '9806 E. Edgewood Dr. Murfreesboro, TN 37128', '2001-04-06');
INSERT INTO Clients(Id, Name, Email, Phones, Address, AddedOn)
VALUES(4, 'Nyla Lindsey', 'quappusiteuyoi-1215@yopmail.com', '205-806-4963', '91 South Union St. Munster, IN 46321', '2005-02-23');
INSERT INTO Clients(Id, Name, Email, Phones, Address, AddedOn)
VALUES(5, 'Vincent Watson', 'wappeleipriki-5914@yopmail.com', '907-323-1639', '89 County St. Florence, SC 29501', '2005-03-03');
INSERT INTO Clients(Id, Name, Email, Phones, Address, AddedOn)
VALUES(6, 'Alayna Klein', 'jelileummissa-8954@yopmail.com', '859-635-2192', '78 Acacia Drive Chelsea, MA 02150', '2006-02-08');
INSERT INTO Clients(Id, Name, Email, Phones, Address, AddedOn)
VALUES(7, 'Tristan Hale', 'tammeyigronau-7702@yopmail.com', '662-904-3379', '304 E. Lilac Drive Smyrna, GA 30080', '2006-08-24');
INSERT INTO Clients(Id, Name, Email, Phones, Address, AddedOn)
VALUES(8, 'George Newman', 'meddayitreppu-3217@yopmail.com', '512-528-6995', '47 South Beacon Lane Land O Lakes, FL 34639', '2009-12-30');
INSERT INTO Clients(Id, Name, Email, Phones, Address, AddedOn)
VALUES(9, 'Jaxon Harrison', 'gruffettoigique-1160@yopmail.com', '337-806-2038', '20 Locust Street San Pablo, CA 94806', '2010-02-19');
INSERT INTO Clients(Id, Name, Email, Phones, Address, AddedOn)
VALUES(10, 'Kiara Murphy', 'velleuppoijaune-2517@yopmail.com', '956-562-7382', '6 Cottage St. Stuart, FL 34997', '2012-02-15');
INSERT INTO Clients(Id, Name, Email, Phones, Address, AddedOn)
VALUES(11, 'Sophie Gomez', 'fesicreugeudoi-1575@yopmail.com', '303-382-2457', '626 West Creek Ave. Apex, NC 27502', '2013-06-27');
INSERT INTO Clients(Id, Name, Email, Phones, Address, AddedOn)
VALUES(12, 'Dexter Rogers', 'toutaqueigriquoi-1354@yopmail.com', '843-499-4476', '253 Lakewood St. Stroudsburg, PA 18360', '2016-09-06');
INSERT INTO Clients(Id, Name, Email, Phones, Address, AddedOn)
VALUES(13, 'Ellie Wright', 'creiyifavubri-8592@yopmail.com', '720-981-0052', '35 Prairie St. Euless, TX 76039', '2017-11-15');
INSERT INTO Clients(Id, Name, Email, Phones, Address, AddedOn)
VALUES(14, 'Melissa Perkins', 'seddinougrehei-1497@yopmail.com', '903-635-2556', '8704 Pilgrim Circle Monsey, NY 10952', '2019-02-26');
INSERT INTO Clients(Id, Name, Email, Phones, Address, AddedOn)
VALUES(15, 'Brody Kelly', 'cozicicillo-7854@yopmail.com', '502-749-8354', '702 University Street Saint Augustine, FL 32084', '2019-05-16');
SET IDENTITY_INSERT Clients OFF

SELECT * FROM Clients


SET IDENTITY_INSERT Interactions ON
INSERT INTO Interactions(Id, EmpId, ClientId, IntType, IntDate, Remarks)
VALUES(1, 2, 1, 'T', '2010-01-20', 'Problem solving');
INSERT INTO Interactions(Id, EmpId, ClientId, IntType, IntDate, Remarks)
VALUES(2, 3, 4, 'S', '2011-12-01', 'Decision making');
INSERT INTO Interactions(Id, EmpId, ClientId, IntType, IntDate, Remarks)
VALUES(3, 5, 5, 'T', '2017-10-04', 'Decision making');
INSERT INTO Interactions(Id, EmpId, ClientId, IntType, IntDate, Remarks)
VALUES(4, 6, 7, 'I', '2020-04-15', 'Building morale');
INSERT INTO Interactions(Id, EmpId, ClientId, IntType, IntDate, Remarks)
VALUES(5, 10, 15, 'I', '2020-01-30', 'Planning');
INSERT INTO Interactions(Id, EmpId, ClientId, IntType, IntDate, Remarks)
VALUES(6, 12, 13, 'I', '2016-08-02', 'Brainstorming');
INSERT INTO Interactions(Id, EmpId, ClientId, IntType, IntDate, Remarks)
VALUES(7, 14, 6, 'W', '2013-10-28', 'Decision making');
SET IDENTITY_INSERT Interactions OFF

SELECT * FROM Interactions
