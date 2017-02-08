using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using SqlSugar;
namespace AchieveEntity
{
	 	//Sys_Flock
    [SugarMapping(TableName = "Sys_Flock")]
	public class Sys_Flock
	{
   		     
      	/// <summary>
		/// F_Id
        /// </summary>
        public string F_Id{ get; set; }        
		/// <summary>
		/// Ⱥ����
        /// </summary>
        public string F_FlockName{ get; set; }        
		/// <summary>
		/// Ⱥ��Ƭ
        /// </summary>
        public string F_Flockphotos{ get; set; }        
		/// <summary>
		/// Ⱥ����
        /// </summary>
        public string F_Description{ get; set; } 
		/// <summary>
		/// ����ʱ��
        /// </summary>
        public DateTime F_CreatorTime{ get; set; }        
		/// <summary>
		/// ������
        /// </summary>
        public string F_CreatorUserId{ get; set; }        
		/// <summary>
		/// �޸�ʱ��
        /// </summary>
        public DateTime F_LastModifyTime{ get; set; }        
		/// <summary>
		/// �޸���
        /// </summary>
        public string F_LastModifyUserId{ get; set; }        
		   
	}
}

