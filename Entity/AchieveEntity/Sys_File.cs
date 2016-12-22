using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using SqlSugar;
namespace AchieveEntity
{
    //���������
    /// <summary>
    /// ����ֻ��Ϊ��ʼ��ӳ�䣬SetMappingTables��SetMappingColumns���Ը���
    /// </summary>
    [SugarMapping(TableName = "Sys_File")]//��������ã��ᱻ
    public class Sys_File
    {

        /// <summary>
        /// ����
        /// </summary>
        public string F_Id { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string F_ParentId { get; set; }
        /// <summary>
        /// �ļ�����
        /// </summary>
        public string F_FileType { get; set; }
        /// <summary>
        /// �ļ���ַ
        /// </summary>
        public string F_FileUrl { get; set; }
        /// <summary>
        /// �ļ�����
        /// </summary>
        public string F_FileName { get; set; }
        /// <summary>
        /// ɾ����־
        /// </summary>
        public bool? F_DeleteMark { get; set; }
        /// <summary>
        /// ��Ч��־
        /// </summary>
        public bool? F_EnabledMark { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string F_Description { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        public DateTime? F_CreatorTime { get; set; }
        /// <summary>
        /// �����û�����
        /// </summary>
        public string F_CreatorUserId { get; set; }
        /// <summary>
        /// ����޸�ʱ��
        /// </summary>
        public DateTime? F_LastModifyTime { get; set; }
        /// <summary>
        /// ����޸��û�
        /// </summary>
        public string F_LastModifyUserId { get; set; }
        /// <summary>
        /// ɾ��ʱ��
        /// </summary>
        public DateTime? F_DeleteTime { get; set; }
        /// <summary>
        /// ɾ���û�
        /// </summary>
        public string F_DeleteUserId { get; set; }

    }
}

