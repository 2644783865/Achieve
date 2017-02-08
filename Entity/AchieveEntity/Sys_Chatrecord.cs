using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using SqlSugar;
namespace AchieveEntity
{
	 	//Sys_Chatrecord
    [SugarMapping(TableName = "Sys_Chatrecord")]
	public class Sys_Chatrecord
	{
   		     
      	/// <summary>
		/// F_Id
        /// </summary>
        public string F_Id{ get; set; }        
		/// <summary>
		/// ������id
        /// </summary>
        public string F_SendId{ get; set; }        
		/// <summary>
		/// ������id
        /// </summary>
        public string F_AcceptId{ get; set; }        
		/// <summary>
		/// ���ͣ�1.�˶��ˣ�2.�˶�Ⱥ��
        /// </summary>
        public int F_Type{ get; set; }        
		/// <summary>
		/// ��Ϣ����
        /// </summary>
        public string F_Message{ get; set; }        
		/// <summary>
		/// ����ʱ��
        /// </summary>
        public DateTime F_CreatorTime{ get; set; }        
		/// <summary>
		/// ������
        /// </summary>
        public string F_CreatorUserId{ get; set; }        
		   
	}
}

