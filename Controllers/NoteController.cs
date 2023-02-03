using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeanstalkNet.DataAccess;
using BeanstalkNet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BeanstalkNet.Controllers
{
    public class NotesController : Controller
    {
        private readonly ILogger<NotesController> _logger;
        private readonly AppDbContext _dbContext;
        public NotesController(ILogger<NotesController> logger, AppDbContext dbContext)
        {
            this._dbContext = dbContext;
            this._logger = logger;
        }
        public async Task<IActionResult> Index()
        {
            var notes = _dbContext.Notes.Select(note => new NoteViewModel
            {
                Id = note.Id,
                Content = note.Content,
                CreatedOn = note.CreatedOn,
                UpdatedOn = note.CreatedOn
            }).ToList<NoteViewModel>();

            var notesViewModel = new NotesViewModel { Notes = notes };
            return View(notesViewModel);
        }
    }
}