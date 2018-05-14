using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace BACS387Group10Project
{
    class Login
    {
        /*
        * MS Instead of returning a String[] here, you could look at using
        * a List<Credential>. Passing around a bunch of strings isn't very OO
        */
        public string[,] login()
        {
            string[,] loginArray = new String[11,3];
            int i = 0;
            foreach (string line in File.ReadAllLines("..//..//users.txt"))
            {
                string[] parts = line.Split('-');
                loginArray[i, 0] = parts[0];
                loginArray[i, 1] = parts[1];
                loginArray[i, 2] = parts[2];
                i++;
            }
            return loginArray;
        }
        public void checkCredentials(Credentials credentials)
        {
            bool search = false;
            bool PWCheck = false;
            bool adminCheck = false;
            int i = 0;
            int member = 0;
            string UN;

            credentials.cred = 3;
            //Creating the array from the text file
            string[,] loginArray = login();
            while (i < 10 & search == false)
            {
                UN = loginArray[i, 0];
                if(UN == credentials.username)
                {
                    search = true;
                    member = i;
                    PWCheck = loginArray[i, 1] == credentials.password;
                    if(PWCheck == true)
                    {
                        if(loginArray[i, 2] == "True")
                        {
                            adminCheck = true;
                        }
                    }
                }
                i++;
            }
            if(search == true & PWCheck == true & adminCheck == true)
            {
                credentials.cred = 1;
            }
            else if(search == true & PWCheck == true & adminCheck == false)
            {
                credentials.cred = 2;
            }
        }
    }
}
