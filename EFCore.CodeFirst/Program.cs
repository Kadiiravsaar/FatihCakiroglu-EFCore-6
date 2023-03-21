using EFCore.CodeFirst;
using EFCore.CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

Initializer.Build();

using (var _context = new AppDbContext())
{
    #region State Örnek

    //var newProduct = new Products { Name = "Kalem 200", Price = 500, Stock = 25, Barcode = 1520 };

    //Console.WriteLine($"İlk State {_context.Entry(newProduct).State}"); GenelNotlar.json 29

    //await _context.products.AddAsync(newProduct);

    //Console.WriteLine($"Son State {_context.Entry(newProduct).State}");



    //await _context.SaveChangesAsync();
    //Console.WriteLine($" SaveChanges'den State {_context.Entry(newProduct).State}");

    #endregion

    var products = await _context.products.AsNoTracking().ToListAsync();

    products.ForEach(p =>
    {

        p.Stock += 10;
        //Console.WriteLine($"{p.Id}:{p.Name}:{p.Price} state : {state}");

    });

    await _context.SaveChangesAsync();

}