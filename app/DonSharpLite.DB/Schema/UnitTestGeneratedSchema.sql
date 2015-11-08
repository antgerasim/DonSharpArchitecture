
    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FKCF71D58AE7858371]') AND parent_object_id = OBJECT_ID('SupportTickets'))
alter table SupportTickets  drop constraint FKCF71D58AE7858371


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FKCF71D58AF7CDF365]') AND parent_object_id = OBJECT_ID('SupportTickets'))
alter table SupportTickets  drop constraint FKCF71D58AF7CDF365


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FKCF71D58ABD9E279A]') AND parent_object_id = OBJECT_ID('SupportTickets'))
alter table SupportTickets  drop constraint FKCF71D58ABD9E279A


    if exists (select * from dbo.sysobjects where id = object_id(N'Customers') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table Customers

    if exists (select * from dbo.sysobjects where id = object_id(N'StaffMembers') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table StaffMembers

    if exists (select * from dbo.sysobjects where id = object_id(N'IssueTypes') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table IssueTypes

    if exists (select * from dbo.sysobjects where id = object_id(N'SupportTickets') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table SupportTickets

    create table Customers (
        Id INT IDENTITY NOT NULL,
       AccountNumber NVARCHAR(255) null,
       FirstName NVARCHAR(255) null,
       LastName NVARCHAR(255) null,
       EmailAddress NVARCHAR(255) null,
       primary key (Id)
    )

    create table StaffMembers (
        Id INT IDENTITY NOT NULL,
       EmployeeNumber NVARCHAR(255) null,
       FirstName NVARCHAR(255) null,
       LastName NVARCHAR(255) null,
       PasswordHash NVARCHAR(255) null,
       Roles INT null,
       primary key (Id)
    )

    create table IssueTypes (
        Id INT IDENTITY NOT NULL,
       Name NVARCHAR(255) null,
       primary key (Id)
    )

    create table SupportTickets (
        Id INT IDENTITY NOT NULL,
       IssueDescription NVARCHAR(255) null,
       CustomerFk INT null,
       WhenOpened DATETIME null,
       StaffMemberFk INT null,
       WhenResolved DATETIME null,
       IssueTypeFk INT null,
       Resolution NVARCHAR(255) null,
       StatusTypeFk INT null,
       primary key (Id)
    )

    alter table SupportTickets 
        add constraint FKCF71D58AE7858371 
        foreign key (CustomerFk) 
        references Customers

    alter table SupportTickets 
        add constraint FKCF71D58AF7CDF365 
        foreign key (StaffMemberFk) 
        references StaffMembers

    alter table SupportTickets 
        add constraint FKCF71D58ABD9E279A 
        foreign key (IssueTypeFk) 
        references IssueTypes
