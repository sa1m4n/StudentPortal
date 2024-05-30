using Microsoft.AspNetCore.Mvc;
using StudentPortalWeb.Models;
using StudentPortalWeb.Data;

namespace StudentPortalWeb.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        public StudentsController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;            
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddStudentViewModel viewModel)
        {
            var student = new Student
            {
                Name = viewModel.Name;
                
            }
            await dbContext.Students.AddAsync();
            return View();
        }
    }
}
