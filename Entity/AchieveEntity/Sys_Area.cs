using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
namespace AchieveEntity
{
    //���������
    public class Sys_Area
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
        /// ��ƴ
        /// </summary>
        public string F_SimpleSpelling { get; set; }
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

        public List<Sys_Area> ChildNodes { get; set; }

    }
}

