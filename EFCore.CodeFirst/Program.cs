﻿using EFCore.CodeFirst;
using EFCore.CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

Initializer.Build();

using (var _context = new AppDbContext())
{
    var products = await _context.products.ToListAsync();

    products.ForEach(p=>
    {
        Console.WriteLine($"{p.Id}:{p.Name}");

    });

    


}