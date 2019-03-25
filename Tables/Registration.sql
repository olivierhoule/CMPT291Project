/*
   March 25, 201911:39:19 AM
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
CREATE TABLE dbo.Registration
	(
	RID int NOT NULL,
	PID int NOT NULL,
	doc_id int NOT NULL,
	ward_id int NOT NULL,
	date date NOT NULL,
	doc_notes varchar(200) NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Registration ADD CONSTRAINT
	PK_Registration PRIMARY KEY CLUSTERED 
	(
	RID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Registration SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Registration', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Registration', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Registration', 'Object', 'CONTROL') as Contr_Per 