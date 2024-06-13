﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DatVeXemPhim.Data;
using DatVeXemPhim.Models;

namespace DatVeXemPhim.Controllers
{
    public class PhongChieusController : Controller
    {
        private readonly DatVeXemPhimContext _context;

        public PhongChieusController(DatVeXemPhimContext context)
        {
            _context = context;
        }

        // GET: QuanLyGhes
        public async Task<IActionResult> Index()
        {
            return View(await _context.PhongChieu.ToListAsync());
        }

        // GET: QuanLyGhes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phongChieu = await _context.PhongChieu
                .FirstOrDefaultAsync(m => m.id == id);
            if (phongChieu == null)
            {
                return NotFound();
            }

            return View(phongChieu);
        }

        // GET: QuanLyGhes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: QuanLyGhes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id, tenPhong")] PhongChieu phongChieu)

        {
            if (ModelState.IsValid)
            {
                _context.Add(phongChieu);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(phongChieu);
        }

        // GET: QuanLyGhes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phongChieu = await _context.PhongChieu.FindAsync(id);
            if (phongChieu == null)
            {
                return NotFound();
            }
            return View(phongChieu);
        }

        // POST: QuanLyGhes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id, tenPhong")] PhongChieu phongChieu)
        {
            if (id != phongChieu.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(phongChieu);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhongChieuExists(phongChieu.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(phongChieu);
        }

        // GET: QuanLyGhes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phongChieu = await _context.PhongChieu
                .FirstOrDefaultAsync(m => m.id == id);
            if (phongChieu == null)
            {
                return NotFound();
            }

            return View(phongChieu);
        }

        // POST: QuanLyGhes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var phongChieu = await _context.PhongChieu.FindAsync(id);
            if (phongChieu != null)
            {
                _context.PhongChieu.Remove(phongChieu);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PhongChieuExists(int id)
        {
            return _context.TheLoaiPhim.Any(e => e.id == id);
        }
    }
}
