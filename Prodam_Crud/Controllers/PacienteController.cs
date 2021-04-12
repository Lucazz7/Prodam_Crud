using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prodam_Crud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prodam_Crud.Controllers
{
    public class PacienteController : Controller
    {
        private readonly Contexto _contexto;
        //Construtor
        public PacienteController(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _contexto.Paciente.ToListAsync());
        }

        [HttpGet]
        public IActionResult CriarPaciente()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CriarPaciente(Paciente paciente)
        {
            if (ModelState.IsValid)
            {
                _contexto.Add(paciente);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            else return View(paciente);
        }

        [HttpGet]
        public IActionResult AtualizarPaciente(int? id)
        {
            if (id != null)
            {
                Paciente paciente = _contexto.Paciente.Find(id);
                return View(paciente);
            }

            else return NotFound();
        }

        [HttpPost]

        public async Task<IActionResult> AtualizarPaciente(int? id, Paciente paciente)
        {
            if (id != null)
            {
                if (ModelState.IsValid)
                {
                    _contexto.Update(paciente);
                    await _contexto.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else return View(paciente);
                
            }
            else return NotFound();
        }

        [HttpGet]
        public IActionResult ExcluirPaciente(int? id)
        {
            if (id != null)
            {
                Paciente paciente = _contexto.Paciente.Find(id);
                return View(paciente);
            }

            else return NotFound();
        }

        [HttpPost]

        public async Task<IActionResult> ExcluirPaciente(int? id, Paciente paciente)
        {
            if (id != null)
            {
                _contexto.Remove(paciente);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else return NotFound();
        }

    }
}
