using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
namespace AchieveEntity
{
    //��֯��
    public class Sys_Organize
    {

        /// <summary>
        /// ��֯����
        /// </summary>
        public string F_Id { get; set; }
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
        /// ���
        /// </summary>
        public string F_ShortName { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string F_CategoryId { get; set; }
        /// <summary>
        /// ������
        /// </summary>
        public string F_ManagerId { get; set; }
        /// <summary>
        /// �绰
        /// </summary>
        public string F_TelePhone { get; set; }
        /// <summary>
        /// �ֻ�
        /// </summary>
        public string F_MobilePhone { get; set; }
        /// <summary>
        /// ΢��
        /// </summary>
        public string F_WeChat { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string F_Fax { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string F_Email { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        public string F_AreaId { get; set; }
        /// <summary>
        /// ��ϵ��ַ
        /// </summary>
        public string F_Address { get; set; }
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
        /// ����ʱ��
        /// </summary>
        public DateTime? F_CreatorTime { get; set; }
        /// <summary>
        /// �����û�
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

        public List<Sys_Organize> ChildNodes { get; set; }

    }
}

