using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSchoolAPI.Utils
{
    public class Messages
    {
        //NEGATIVE:
        public static readonly string ERROR = "Error";
        public static readonly string USER_EXISTS = "User already exists!";
        public static readonly string FAILED_USER_CREATION = "User creation failed! Please check user details and try again.";

        //POSITIVE:
        public static readonly string USER_SUCCESSFULY_CREATED = "User created successfully!";
        public static readonly string SUCCESS = "Success";

    }
}
