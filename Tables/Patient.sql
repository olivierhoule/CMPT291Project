/*
   March 25, 201911:47:16 AM
   User: 
   Server: DESKTOP-C18JR3B
   Database: Cmpt_291_Project
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Patient
	(
	PID int NOT NULL,
	first_name varchar(50) NOT NULL,
	last_name varchar(50) NOT NULL,
	house_number int NOT NULL,
	street varchar(50) NOT NULL,
	city varchar(50) NOT NULL,
	postal_code varchar(7) NOT NULL,
	province varchar(100) NOT NULL,
	date_of_birth date NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Patient SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Patient', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Patient', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Patient', 'Object', 'CONTROL') as Contr_Per 