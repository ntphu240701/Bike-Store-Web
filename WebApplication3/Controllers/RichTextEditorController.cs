using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class RichTextEditorController : Controller

    {
        // GET: RichTextEditor
        
        
            // GET: Home
            public ActionResult Index()
            {
                PersonModel m = new PersonModel()
                {

                    PersonalDetails = "<table class=\"plugin-info\" style=\"margin: 0px; padding: 0px; border: 0px; outline: 0px; font-size: 0.875em; vertical-align: baseline; background: 0px 0px #ffffff; border-spacing: 0px; width: 300px; color: #333333; font-family: Helvetica, Arial, sans-serif;\">\r\n<tbody style=\"margin: 0px; padding: 0px; border: 0px; outline: 0px; vertical-align: baseline; background: 0px 0px;\">\r\n<tr style=\"margin: 0px; padding: 0px; border: 0px; outline: 0px; vertical-align: baseline; background: 0px 0px;\">\r\n<th style=\"margin: 0px; padding: 0px; border: 0px; outline: 0px; vertical-align: baseline; background: 0px 0px; height: 24px; line-height: 24px; text-align: left;\" width=\"126\">File Size:</th>\r\n<td style=\"margin: 0px; padding: 0px; border: 0px; outline: 0px; vertical-align: baseline; background: 0px 0px;\" width=\"162\">380 KB</td>\r\n</tr>\r\n<tr style=\"margin: 0px; padding: 0px; border: 0px; outline: 0px; vertical-align: baseline; background: 0px 0px;\">\r\n<th style=\"margin: 0px; padding: 0px; border: 0px; outline: 0px; vertical-align: baseline; background: 0px 0px; height: 24px; line-height: 24px; text-align: left;\">Views Total:</th>\r\n<td style=\"margin: 0px; padding: 0px; border: 0px; outline: 0px; vertical-align: baseline; background: 0px 0px;\">17344</td>\r\n</tr>\r\n<tr style=\"margin: 0px; padding: 0px; border: 0px; outline: 0px; vertical-align: baseline; background: 0px 0px;\">\r\n<th style=\"margin: 0px; padding: 0px; border: 0px; outline: 0px; vertical-align: baseline; background: 0px 0px; height: 24px; line-height: 24px; text-align: left;\">Last Update:</th>\r\n<td style=\"margin: 0px; padding: 0px; border: 0px; outline: 0px; vertical-align: baseline; background: 0px 0px;\"><time class=\"timeago\" style=\"margin: 0px; padding: 0px; border: 0px; outline: 0px; vertical-align: baseline; background: 0px 0px;\" title=\"03/11/2021 12:23:00 UTC\" datetime=\"2021-03-11T12:23:00Z\">12 months ago</time></td>\r\n</tr>\r\n<tr style=\"margin: 0px; padding: 0px; border: 0px; outline: 0px; vertical-align: baseline; background: 0px 0px;\">\r\n<th style=\"margin: 0px; padding: 0px; border: 0px; outline: 0px; vertical-align: baseline; background: 0px 0px; height: 24px; line-height: 24px; text-align: left;\">Publish Date:</th>\r\n<td style=\"margin: 0px; padding: 0px; border: 0px; outline: 0px; vertical-align: baseline; background: 0px 0px;\"><time class=\"timeago\" style=\"margin: 0px; padding: 0px; border: 0px; outline: 0px; vertical-align: baseline; background: 0px 0px;\" title=\"03/26/2020 03:32:27 UTC\" datetime=\"2020-03-26T03:32:27Z\">2 years ago</time></td>\r\n</tr>\r\n<tr style=\"margin: 0px; padding: 0px; border: 0px; outline: 0px; vertical-align: baseline; background: 0px 0px;\">\r\n<th style=\"margin: 0px; padding: 0px; border: 0px; outline: 0px; vertical - align: baseline; background: 0px 0px; height: 24px; line - height: 24px; text - align: left;\">Official Website:</th>\r\n<td style=\"margin: 0px; padding: 0px; border: 0px; outline: 0px; vertical-align: baseline; background: 0px 0px;\"><a style=\"outline: 0px; color: #316594; text-decoration-line: none;\" href=\"https://github.com/wdmg/bootstrap-wysiwyg\" target=\"_blank\" rel=\"nofollow noopener\">Go to website</a></td>\r\n</tr>\r\n</tbody>\r\n</table>"
    
            };
            return View(m);
        }

        [HttpPost]
        public ActionResult Index(PersonModel person)
        {

            string details = person.PersonalDetails;

            return View(person);
        }
    }
}
