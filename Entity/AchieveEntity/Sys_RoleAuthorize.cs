using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
namespace AchieveEntity
{
    //��ɫ��Ȩ��
    public class Sys_RoleAuthorize
    {

        /// <summary>
        /// ��ɫ��Ȩ����
        /// </summary>
        public string F_Id { get; set; }
        /// <summary>
        /// ��Ŀ����1-ģ��2-��ť3-�б�
        /// </summary>
        public int F_ItemType { get; set; }
        /// <summary>
        /// ��Ŀ����
        /// </summary>
        public string F_ItemId { get; set; }
        /// <summary>
        /// �������1-��ɫ2-����-3�û�
        /// </summary>
        public int F_ObjectType { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        public string F_ObjectId { get; set; }
        /// <summary>
        /// ������
        /// </summary>
        public int F_SortCode { get; set; }
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

