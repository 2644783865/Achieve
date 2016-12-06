using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using SqlSugar;
namespace AchieveEntity
{
    //ѡ����ϸ��
    /// <summary>
    /// ����ֻ��Ϊ��ʼ��ӳ�䣬SetMappingTables��SetMappingColumns���Ը��ǣ��ɰ��Լ�ϲ��ѡ��
    /// </summary>
    [SugarMapping(TableName = "Sys_ItemsDetail")]
    public class Sys_ItemsDetail
    {

        /// <summary>
        /// ��ϸ����
        /// </summary>
        public string F_Id { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        public string F_ItemId { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string F_ParentId { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string F_ItemCode { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string F_ItemName { get; set; }
        /// <summary>
        /// ��ƴ
        /// </summary>
        public string F_SimpleSpelling { get; set; }
        /// <summary>
        /// Ĭ��
        /// </summary>
        public bool? F_IsDefault { get; set; }
        /// <summary>
        /// ���
        /// </summary>
        public int? F_Layers { get; set; }
        /// <summary>
        /// ������
        /// </summary>
        public int? F_SortCode { get; set; }
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

