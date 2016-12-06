using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using SqlSugar;
namespace AchieveEntity
{
    //ϵͳ��־
    /// <summary>
    /// ����ֻ��Ϊ��ʼ��ӳ�䣬SetMappingTables��SetMappingColumns���Ը��ǣ��ɰ��Լ�ϲ��ѡ��
    /// </summary>
    [SugarMapping(TableName = "Sys_ItemsDetail")]
    public class Sys_LogEntity
    {

        /// <summary>
        /// ��־����
        /// </summary>
        public string F_Id { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public DateTime F_Date { get; set; }
        /// <summary>
        /// �û���
        /// </summary>
        public string F_Account { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string F_NickName { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string F_Type { get; set; }
        /// <summary>
        /// IP��ַ
        /// </summary>
        public string F_IPAddress { get; set; }
        /// <summary>
        /// IP���ڳ���
        /// </summary>
        public string F_IPAddressName { get; set; }
        /// <summary>
        /// ϵͳģ��Id
        /// </summary>
        public string F_ModuleId { get; set; }
        /// <summary>
        /// ϵͳģ��
        /// </summary>
        public string F_ModuleName { get; set; }
        /// <summary>
        /// ���
        /// </summary>
        public bool F_Result { get; set; }
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

    }
}

