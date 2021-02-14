using Fiorella.DAL;
using Fiorella.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {

        private readonly AppDbContext _context;

        public HeaderViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            Bio model = _context.Bio.FirstOrDefault();
            return View(await Task.FromResult(model));


        }


    }
}
