using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
namespace AchieveEntity
{
    //�û���¼��Ϣ��
    public class Sys_UserLogOn
    {

        /// <summary>
        /// �û���¼����
        /// </summary>
        public string F_Id { get; set; }
        /// <summary>
        /// �û�����
        /// </summary>
        public string F_UserId { get; set; }
        /// <summary>
        /// �û�����
        /// </summary>
        public string F_UserPassword { get; set; }
        /// <summary>
        /// �û���Կ
        /// </summary>
        public string F_UserSecretkey { get; set; }
        /// <summary>
        /// �����¼ʱ�俪ʼ
        /// </summary>
        public DateTime F_AllowStartTime { get; set; }
        /// <summary>
        /// �����¼ʱ�����
        /// </summary>
        public DateTime F_AllowEndTime { get; set; }
        /// <summary>
        /// ��ͣ�û���ʼ����
        /// </summary>
        public DateTime F_LockStartDate { get; set; }
        /// <summary>
        /// ��ͣ�û���������
        /// </summary>
        public DateTime F_LockEndDate { get; set; }
        /// <summary>
        /// ��һ�η���ʱ��
        /// </summary>
        public DateTime F_FirstVisitTime { get; set; }
        /// <summary>
        /// ��һ�η���ʱ��
        /// </summary>
        public DateTime F_PreviousVisitTime { get; set; }
        /// <summary>
        /// ������ʱ��
        /// </summary>
        public DateTime F_LastVisitTime { get; set; }
        /// <summary>
        /// ����޸���������
        /// </summary>
        public DateTime F_ChangePasswordDate { get; set; }
        /// <summary>
        /// ����ͬʱ�ж��û���¼
        /// </summary>
        public bool F_MultiUserLogin { get; set; }
        /// <summary>
        /// ��¼����
        /// </summary>
        public int F_LogOnCount { get; set; }
        /// <summary>
        /// ����״̬
        /// </summary>
        public bool F_UserOnLine { get; set; }
        /// <summary>
        /// ������ʾ����
        /// </summary>
        public string F_Question { get; set; }
        /// <summary>
        /// ������ʾ��
        /// </summary>
        public string F_AnswerQuestion { get; set; }
        /// <summary>
        /// �Ƿ��������
        /// </summary>
        public bool F_CheckIPAddress { get; set; }
        /// <summary>
        /// ϵͳ����
        /// </summary>
        public string F_Language { get; set; }
        /// <summary>
        /// ϵͳ��ʽ
        /// </summary>
        public string F_Theme { get; set; }

    }
}

