CREATE TABLE [dbo].[Sys_File](
	[F_Id] [varchar](50) NOT NULL,
	[F_ParentId] [varchar](50) NULL,
	[F_FileType] [varchar](10) NULL,
	[F_FileUrl] [varchar](100) NULL,
	[F_FileName] [varchar](50) NULL,
	[F_DeleteMark] [bit] NULL,
	[F_EnabledMark] [bit] NULL,
	[F_Description] [varchar](500) NULL,
	[F_CreatorTime] [datetime] NULL,
	[F_CreatorUserId] [varchar](50) NULL,
	[F_LastModifyTime] [datetime] NULL,
	[F_LastModifyUserId] [varchar](50) NULL,
	[F_DeleteTime] [datetime] NULL,
	[F_DeleteUserId] [varchar](50) NULL,
 CONSTRAINT [PK_Sys_File] PRIMARY KEY NONCLUSTERED 
(
	[F_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_File', @level2type=N'COLUMN',@level2name=N'F_Id'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_File', @level2type=N'COLUMN',@level2name=N'F_ParentId'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�ļ�����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_File', @level2type=N'COLUMN',@level2name=N'F_FileType'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�ļ���ַ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_File', @level2type=N'COLUMN',@level2name=N'F_FileUrl'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�ļ�����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_File', @level2type=N'COLUMN',@level2name=N'F_FileName'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ɾ����־' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_File', @level2type=N'COLUMN',@level2name=N'F_DeleteMark'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��Ч��־' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_File', @level2type=N'COLUMN',@level2name=N'F_EnabledMark'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_File', @level2type=N'COLUMN',@level2name=N'F_Description'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��������' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_File', @level2type=N'COLUMN',@level2name=N'F_CreatorTime'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����û�����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_File', @level2type=N'COLUMN',@level2name=N'F_CreatorUserId'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����޸�ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_File', @level2type=N'COLUMN',@level2name=N'F_LastModifyTime'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����޸��û�' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_File', @level2type=N'COLUMN',@level2name=N'F_LastModifyUserId'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ɾ��ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_File', @level2type=N'COLUMN',@level2name=N'F_DeleteTime'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ɾ���û�' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_File', @level2type=N'COLUMN',@level2name=N'F_DeleteUserId'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�ļ������' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_File'
GO


