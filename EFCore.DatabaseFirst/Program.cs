using EFCore.DatabaseFirst.DataAccessLayer;
using Microsoft.EntityFrameworkCore;

DbContextInitializer.Build();

using (var _context = new AppDbContext(DbContextInitializer.OptionsBuilder.Options))
{
    var products = await _context.Products.ToListAsync();

    products.ForEach(p =>
    {
        Console.WriteLine($"{p.Id} : {p.Name} {p.Price} {p.Stock}");
    });
   

    // neden using kullandık? : 
    // Cevap: İşim bittiği zaman Bu DbContext memory'den dispose(elden çıkartmak, ortadan kaldırmak anlamına gelir.) olsun.
    // using bittiği anda DbContext iptal olur.
}