using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
namespace AchieveEntity
{
    //�û���
    public class Sys_User
    {

        /// <summary>
        /// �û�����
        /// </summary>
        public string F_Id { get; set; }
        /// <summary>
        /// �˻�
        /// </summary>
        public string F_Account { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string F_RealName { get; set; }
        /// <summary>
        /// �س�
        /// </summary>
        public string F_NickName { get; set; }
        /// <summary>
        /// ͷ��
        /// </summary>
        public string F_HeadIcon { get; set; }
        /// <summary>
        /// �Ա�
        /// </summary>
        public bool? F_Gender { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public DateTime? F_Birthday { get; set; }
        /// <summary>
        /// �ֻ�
        /// </summary>
        public string F_MobilePhone { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string F_Email { get; set; }
        /// <summary>
        /// ΢��
        /// </summary>
        public string F_WeChat { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        public string F_ManagerId { get; set; }
        /// <summary>
        /// ��ȫ����
        /// </summary>
        public int F_SecurityLevel { get; set; }
        /// <summary>
        /// ����ǩ��
        /// </summary>
        public string F_Signature { get; set; }
        /// <summary>
        /// ��֯����
        /// </summary>
        public string F_OrganizeId { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        public string F_DepartmentId { get; set; }
        /// <summary>
        /// ��ɫ����
        /// </summary>
        public string F_RoleId { get; set; }
        /// <summary>
        /// ��λ����
        /// </summary>
        public string F_DutyId { get; set; }
        /// <summary>
        /// �Ƿ����Ա
        /// </summary>
        public bool? F_IsAdministrator { get; set; }
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
        /// <summary>
        /// ����
        /// </summary>
        public string F_Password { get; set; }


    }
}

