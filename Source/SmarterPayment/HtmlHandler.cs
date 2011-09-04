using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmarterPayment
{
    public class HtmlHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.Write(@"
<!DOCTYPE html>

<html>
<head>
    <title>Test</title>
</head>
<body>
    <div>
        Test
    </div>
</body>
</html>
");
            context.Response.ContentType = "html";
        }

        public bool IsReusable
        {
            get { return true; }
        }
    }
}