using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using SqlSugar;
namespace AchieveEntity
{
    //ģ���
    /// <summary>
    /// ����ֻ��Ϊ��ʼ��ӳ�䣬SetMappingTables��SetMappingColumns���Ը��ǣ��ɰ��Լ�ϲ��ѡ��
    /// </summary>
    [SugarMapping(TableName = "Sys_ModuleForm")]
    public class Sys_ModuleForm
    {

        /// <summary>
        /// ������
        /// </summary>
        public string F_Id { get; set; }
        /// <summary>
        /// ģ������
        /// </summary>
        public string F_ModuleId { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string F_EnCode { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string F_FullName { get; set; }
        /// <summary>
        /// ���ؼ�Json
        /// </summary>
        public string F_FormJson { get; set; }
        /// <summary>
        /// ������
        /// </summary>
        public int F_SortCode { get; set; }
        /// <summary>
        /// ɾ����־
        /// </summary>
        public bool F_DeleteMark { get; set; }
        /// <summary>
        /// ��Ч��־
        /// </summary>
        public bool F_EnabledMark { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string F_Description { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime F_CreatorTime { get; set; }
        /// <summary>
        /// �����û�
        /// </summary>
        public string F_CreatorUserId { get; set; }
        /// <summary>
        /// ����޸�ʱ��
        /// </summary>
        public DateTime F_LastModifyTime { get; set; }
        /// <summary>
        /// ����޸��û�
        /// </summary>
        public string F_LastModifyUserId { get; set; }
        /// <summary>
        /// ɾ��ʱ��
        /// </summary>
        public DateTime F_DeleteTime { get; set; }
        /// <summary>
        /// ɾ���û�
        /// </summary>
        public string F_DeleteUserId { get; set; }

    }
}

