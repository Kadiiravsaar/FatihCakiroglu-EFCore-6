using EFCore.DatabaseFirst.DataAccessLayer;
using Microsoft.EntityFrameworkCore;

using (var _context = new AppDbContext())
{
    var products = await _context.Products.ToListAsync();

    products.ForEach(p =>
    {
        Console.WriteLine($"{p.Id} : {p.Name} {p.Price}");
    });
   

    // neden using kullandık? : 
    // Cevap: İşim bittiği zaman Bu DbContext memory'den dispose(elden çıkartmak, ortadan kaldırmak anlamına gelir.) olsun.
    // using bittiği anda DbContext iptal olur.
}