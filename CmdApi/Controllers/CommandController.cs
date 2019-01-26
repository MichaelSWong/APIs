using System.Collections.Generic;
using Microsoft.AspnetCore.Mvc;

namespace CmdApi.Controllers
{
    public class CommandsController: ControllerBase
    {
        public ActionResult<IEnumerable<string>> GetString()
        {
            return new string[] {"this", "is", "hard", "coded"};
        }
    } 
}