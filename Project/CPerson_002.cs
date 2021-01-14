using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    [Serializable()]
    public abstract class CPerson_002
    {
        #region Public interface
        public string Username
        {
            get { return m_str_username; }
            set { m_str_username = value; }
        }
        public string ID
        {
            get { return m_str_id; }
            set { m_str_id = value; }
        }
        public string Email
        {
            get { return m_str_email; }
            set { m_str_email = value; }
        }
        public DateTime DateofBirth
        {
            get { return m_str_date_of_birth; }
            set { m_str_date_of_birth = value; }
        }
        public string PhoneNum
        {
            get { return m_str_phone_num; }
            set { m_str_phone_num = value; }

        }
        #endregion
        #region Data Structure
        #endregion
        #region Members
        protected string m_str_username;
        protected string m_str_id;
        protected string m_str_email;
        protected DateTime m_str_date_of_birth;
        protected string m_str_phone_num;
        #endregion
        #region Private Methods
        #endregion

    }
}
