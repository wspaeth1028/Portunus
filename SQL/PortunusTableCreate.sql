USE [Portunus]
DROP TABLE [dbo].[PortunusFileNameConfig]
DROP TABLE [dbo].[PortunusMoveConfig]

/****** Object:  Table [dbo].[PortunusConfig]    Script Date: 3/29/2018 11:28:22 AM ******/
CREATE TABLE [dbo].[PortunusMoveConfig](
	[IdMove] [int] NOT NULL,
	[Description] [varchar](256) NOT NULL,
	[DirLocal] [varchar](MAX) NOT NULL,
	[DirSFTP] [varchar](MAX) NOT NULL,
	[DirBackup] [varchar](MAX) NOT NULL,
	[DirPostProcessExe] [varchar](MAX) NOT NULL,
	[SecureCorp] [varchar](15) NOT NULL,
	[PushToPullFromSFTP] [varchar](15) NOT NULL,
	PRIMARY KEY ([IdMove])
)

INSERT INTO [dbo].[PortunusMoveConfig]([IdMove],[Description],[DirLocal],[DirSFTP],[DirBackup],[DirPostProcessExe],[SecureCorp],[PushToPullFromSFTP])
     VALUES(1,'TestCorpPushToSFTP','C:\temp\PortunusFiles','/_Transfer/PortunusTest/CorpPushtoSFTP','C:\temp\PortunusBackup','PostProcessExe\PortunusKeySecure\PortunusKeySecure.exe','Corp','Push')
INSERT INTO [dbo].[PortunusMoveConfig]([IdMove],[Description],[DirLocal],[DirSFTP],[DirBackup],[DirPostProcessExe],[SecureCorp],[PushToPullFromSFTP])
     VALUES(2,'TestCorpPullFromSFTP','C:\temp\PortunusFiles','/_Transfer/PortunusTest/CorpPullFromSFTP','C:\temp\PortunusBackup','PostProcessExe\PortunusKeySecure\PortunusKeySecure.exe','Corp','Pull')
INSERT INTO [dbo].[PortunusMoveConfig]([IdMove],[Description],[DirLocal],[DirSFTP],[DirBackup],[DirPostProcessExe],[SecureCorp],[PushToPullFromSFTP])
     VALUES(3,'TestSecurePushToSFTP','CODATASRV\Will''s EMV\PortunusFiles','/_Transfer/PortunusTest/SecurePushtoSFTP','CODATASRV\Portunus\Backup','PostProcessExe\PortunusKeySecure\PortunusKeySecure.exe','Secure','Push')
INSERT INTO [dbo].[PortunusMoveConfig]([IdMove],[Description],[DirLocal],[DirSFTP],[DirBackup],[DirPostProcessExe],[SecureCorp],[PushToPullFromSFTP])
     VALUES(4,'TestSecurePullFromSFTP','CODATASRV\Portunus\Test','/_Transfer/PortunusTest/SecurePullFromSFTP','CODATASRV\Portunus\Backup','PostProcessExe\PortunusKeySecure\PortunusKeySecure.exe','Secure','Pull')


/****** Object:  Table [dbo].[PortunusConfig]    Script Date: 3/29/2018 11:28:22 AM ******/
CREATE TABLE [dbo].[PortunusFileNameConfig](
	[IdFileName] [int] NOT NULL,
	[IdMove] [int] NOT NULL,
	[Extension] [varchar](15) NOT NULL,
	PRIMARY KEY ([IdFileName]),
	FOREIGN KEY ([IdMove]) REFERENCES [dbo].[PortunusMoveConfig]
)

INSERT INTO [dbo].[PortunusFileNameConfig]([IdFileName],[IdMove],[Extension])
     VALUES(1,1,'txt')
INSERT INTO [dbo].[PortunusFileNameConfig]([IdFileName],[IdMove],[Extension])
     VALUES(2,1,'doc')
INSERT INTO [dbo].[PortunusFileNameConfig]([IdFileName],[IdMove],[Extension])
     VALUES(3,2,'mcd')
