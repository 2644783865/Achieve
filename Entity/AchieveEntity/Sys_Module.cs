using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
namespace AchieveEntity
{
    //ϵͳģ��
    public class Sys_Module
    {

        /// <summary>
        /// ģ������
        /// </summary>
        public string F_Id { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string F_ParentId { get; set; }
        /// <summary>
        /// ���
        /// </summary>
        public int F_Layers { get; set; }
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
        /// ����
        /// </summary>
        public string F_UrlAddress { get; set; }
        /// <summary>
        /// Ŀ��
        /// </summary>
        public string F_Target { get; set; }
        /// <summary>
        /// �˵�
        /// </summary>
        public bool? F_IsMenu { get; set; }
        /// <summary>
        /// չ��
        /// </summary>
        public bool? F_IsExpand { get; set; }
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

        public List<Sys_Module> ChildNodes { get; set; }

    }
}

