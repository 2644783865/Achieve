using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
namespace AchieveEntity
{
    //ģ���ʵ��
    public class Sys_ModuleFormInstance
    {

        /// <summary>
        /// ��ʵ������
        /// </summary>
        public string F_Id { get; set; }
        /// <summary>
        /// ������
        /// </summary>
        public string F_FormId { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        public string F_ObjectId { get; set; }
        /// <summary>
        /// ��ʵ��Json
        /// </summary>
        public string F_InstanceJson { get; set; }
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

