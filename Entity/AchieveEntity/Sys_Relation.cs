using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using SqlSugar;
namespace AchieveEntity
{
	 	//Sys_Relation
    [SugarMapping(TableName = "Sys_Relation")]
	public class Sys_Relation
	{
   		     
      	/// <summary>
		/// F_Id
        /// </summary>
        public string F_Id{ get; set; }        
		/// <summary>
		/// �û�id
        /// </summary>
        public string F_UserId{ get; set; }        
		/// <summary>
		/// ����id
        /// </summary>
        public string F_FriendId{ get; set; }        
		/// <summary>
		/// ��ϵ���ͣ�1.�˶��ˣ�2.�˶�Ⱥ��
        /// </summary>
        public int F_Type{ get; set; }        
		/// <summary>
		/// ����
        /// </summary>
        public string F_Group{ get; set; }
		/// <summary>
		/// ����ʱ��
        /// </summary>
        public DateTime F_CreatorTime{ get; set; }        
		/// <summary>
		/// ������id
        /// </summary>
        public string F_CreatorUserId{ get; set; }        
		   
	}
}

