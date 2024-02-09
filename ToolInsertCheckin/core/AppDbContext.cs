using Infra.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolInsertCheckin.Core
{
    public class AppDbContext
    {
        private readonly HRMDbContext _hrmDbContext;
        private readonly WebcamDbContext _webCamDbContext;
        public AppDbContext(HRMDbContext hrmDbContext, WebcamDbContext webcamDbContext)
        {
            _hrmDbContext = hrmDbContext;
            _webCamDbContext = webcamDbContext;
        }


        public HRMDbContext Hrm => _hrmDbContext;
        public WebcamDbContext Webcam => _webCamDbContext;
    }
}
