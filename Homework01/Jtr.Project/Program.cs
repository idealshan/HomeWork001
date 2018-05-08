using Jtr.DAL;
using Jtr.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jtr.Project
{
    public class Program
    {


        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("This is Homework Lesson");

                BaseDAL baseDAL =  new BaseDAL();
 
                Company company1 = baseDAL.Find<Company>(1);

              

               /// List<Company> list = baseDAL.FindAll<Company>();

                User user = baseDAL.Find<User>(1);


                //List<User> list = baseDAL.FindAll<User>();

                //company.Name = "腾讯课堂234564576754";
                ////company.Validate();
                //baseDAL.Update<Company>(company);

              
                //
            }
            catch (Exception ex)//UI层必须把异常catch住
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }

    }
}
