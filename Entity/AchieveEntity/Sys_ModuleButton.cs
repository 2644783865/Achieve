using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using SqlSugar;
namespace AchieveEntity
{
    //ģ�鰴ť
    /// <summary>
    /// ����ֻ��Ϊ��ʼ��ӳ�䣬SetMappingTables��SetMappingColumns���Ը��ǣ��ɰ��Լ�ϲ��ѡ��
    /// </summary>
    [SugarMapping(TableName = "Sys_ModuleButton")]
    public class Sys_ModuleButton
    {

        /// <summary>
        /// ��ť����
        /// </summary>
        public string F_Id { get; set; }
        /// <summary>
        /// ģ������
        /// </summary>
        public string F_ModuleId { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string F_ParentId { get; set; }
        /// <summary>
        /// ���
        /// </summary>
        public int? F_Layers { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string F_EnCode { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string F_FullName { get; set; }
        /// <summary>
        /// ͼ��
        /// </summary>
        public string F_Icon { get; set; }
        /// <summary>
        /// λ��
        /// </summary>
        public int? F_Location { get; set; }
        /// <summary>
        /// �¼�
        /// </summary>
        public string F_JsEvent { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string F_UrlAddress { get; set; }
        /// <summary>
        /// �ֿ���
        /// </summary>
        public bool? F_Split { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public bool? F_IsPublic { get; set; }
        /// <summary>
        /// ����༭
        /// </summary>
        public bool? F_AllowEdit { get; set; }
        /// <summary>
        /// ����ɾ��
        /// </summary>
        public bool? F_AllowDelete { get; set; }
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

