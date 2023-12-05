use EMS_DATABASE


CREATE TABLE USERS 

(
   id int primary key identity, 
   username varchar(50) NOT NULL,
   [password] varchar(50) NOT NULL,
   userrole int
);


CREATE TABLE  [ROLE]

(
   roleid int primary key identity,
   roletype varchar(100) 

);

INSERT INTO USERS values('admin', 'admin', 1);
INSERT INTO USERS values('user', 'user', 2);
INSERT INTO USERS values('employee', 'employee', 3);

select * from USERS inner join role on users.userrole = [ROLE].roleid
where username = 'admin' and [password] = 'admin';

SELECT * FROM USERS


INSERT INTO [ROLE] values ('admin')
INSERT INTO [ROLE] values ('user')
INSERT INTO [ROLE] values ('employee')


SELECT * FROM  [ROLE]



