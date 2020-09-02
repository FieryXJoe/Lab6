using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MidTermProject;
using System.Data;
using System.Data.SqlClient;

namespace Lab5
{
    class PersonV2 : Person
    {
        private string cellNum, instagramURL;
        public PersonV2(): base()
        {
            cellNum = "";
            instagramURL = "";
        }
        public PersonV2(Person p): base(p)
        {
            cellNum = "";
            instagramURL = "";
        }
        public PersonV2(Person p, string _cellNum, string _instagramURL): base(p)
        {
            CellNum = _cellNum;
            InstagramURL = _instagramURL;
        }
        public PersonV2(string _fName, string _mName, string _lName, string _streetOne, string _streetTwo, string _city, string _stateCode, string _zipCode, string _phoneNum, string _emailAddress, string _cellNum, string _instagramURL)
        :base(_fName, _mName, _lName, _streetOne, _streetTwo, _city, _stateCode, _zipCode, _phoneNum, _emailAddress)
        {
            CellNum = _cellNum;
            InstagramURL = _instagramURL;
        }
        public string CellNum
        {
            get
            {
                return cellNum;
            }
            set
            {
                if (BasicTools.isValidPhoneNum(value))
                    cellNum = value;
                else
                {
                    cellNum = "";
                    Feedback += "\n Error: Cell Phone Number";
                }
            }
        }
        public string InstagramURL
        {
            get
            {
                return instagramURL;
            }
            set
            {
                if (BasicTools.isValidInstaURL(value))
                    instagramURL = value;
                else
                {
                    instagramURL = "";
                    Feedback += "\n Error: Instagram URL";
                }
            }
        }
        public string AddARecord()
        {
            //Init string var
            string strResult = "";

            //Make a connection object
            SqlConnection Conn = new SqlConnection();

            //Initialize it's properties
            Conn.ConnectionString = @"Server=sql.neit.edu\sqlstudentserver,4500;Database=SE245_JSherry;User Id=SE245_JSherry;Password=005501736;";     //Set the Who/What/Where of DB


            //*******************************************************************************************************
            // NEW
            //*******************************************************************************************************
            string strSQL = "INSERT INTO PersonV2 (FName, MName, LName, StreetOne, StreetTwo, City, StateCode, ZipCode, PhoneNum, Email, CellNum, InstagramUrl) VALUES (@FName, @MName, @LName, @StOne, @StTwo, @City, @StCode, @ZipCode, @PhoneNum, @Email, @CellNum, @InstaURL)";
            // Bark out our command
            SqlCommand comm = new SqlCommand();
            comm.CommandText = strSQL;  //Commander knows what to say
            comm.Connection = Conn;     //Where's the phone?  Here it is
            //string _fName, string _mName, string _lName, string _streetOne, string _streetTwo, string _city, string _stateCode, string _zipCode, string _phoneNum, string _emailAddress, string _cellNum, string _instagramURL
            //Fill in the paramters (Has to be created in same sequence as they are used in SQL Statement)
            comm.Parameters.AddWithValue("@FName", FName);
            comm.Parameters.AddWithValue("@MName", MName);
            comm.Parameters.AddWithValue("@LName", LName);
            comm.Parameters.AddWithValue("@StOne", StreetOne);
            comm.Parameters.AddWithValue("@StTwo", StreetTwo);
            comm.Parameters.AddWithValue("@City", City);
            comm.Parameters.AddWithValue("@StCode", StateCode);
            comm.Parameters.AddWithValue("@ZipCode", ZipCode);
            comm.Parameters.AddWithValue("@PhoneNum", PhoneNum);
            comm.Parameters.AddWithValue("@Email", EmailAddress);
            comm.Parameters.AddWithValue("@CellNum", CellNum);
            comm.Parameters.AddWithValue("@InstaURL", InstagramURL);

            //*******************************************************************************************************





            //attempt to connect to the server
            try
            {
                Conn.Open();                                        //Open connection to DB - Think of dialing a friend on phone
                int intRecs = comm.ExecuteNonQuery();
                strResult = $"\nSUCCESS: Inserted {intRecs} records.";       //Report that we made the connection and added a record
                Conn.Close();                                       //Hanging up after phone call
            }
            catch (Exception err)                                   //If we got here, there was a problem connecting to DB
            {
                strResult = "\nERROR: " + err.Message;                //Set feedback to state there was an error & error info
            }
            finally
            {

            }


            //Return resulting feedback string
            return strResult;
        }
    }
}
