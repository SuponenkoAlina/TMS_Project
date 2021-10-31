using BLL.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers.Writer
{
    public class WriterController : Controller
    {
        private readonly IWriterService _writerService;

        public WriterController(IWriterService _writerService)
        {
            this._writerService = _writerService;
        }
    }
}
