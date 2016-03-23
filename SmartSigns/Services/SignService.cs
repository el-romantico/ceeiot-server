using SmartSigns.Models;

namespace SmartSigns.Services
{
    public class SignService
    {
        public SignInfoDto GetSignInfo(string signId)
        {
            // Call DB 
            SignInfoDto result;
            if(signId == "test") // Check if we have data from DB
            {
                result =  new SignInfoDto { HasInfo = true, Info = "This is some test info" };
            }
            else
            {
                result = new SignInfoDto { HasInfo = false };
            }
            return result;
        }
    }
}
