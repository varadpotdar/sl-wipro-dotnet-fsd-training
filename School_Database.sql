/****** Script for SelectTopNRows command from SSMS  ******/
 use [School]
 insert into Student (ID,Name,Address, Email,Class) values ('1','Tom', 'some address', 'tom@email.com','7a');
insert into Student (ID,Name,Address, Email,Class) values ('2','varad', 'some address', 'var@email.com','7a');
insert into Student (ID,Name,Address, Email,Class) values ('3','Aakash', 'some address', 'ak@email.com','7a');  

select * from student;
  select name from student;
    
	  
  update student set class = '8a';
  update student set name = 'Tom Clancy' where name = 'Tom';

    delete from student where name = 'Tom Clancy'
  delete from student

  select * from student where name like 'm%';
  select * from student where email = 'thomas@email.com' and class='8a';
  select * from student order by name;
  


  declare @namevalue as varchar(100)
set @namevalue = 'varad'
 use school
select * from student where name  = @namevalue



  select * from Student