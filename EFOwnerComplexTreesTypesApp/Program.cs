using EFOwnerComplexTreesTypesApp;

using (HrDbContext context = new())
{
    context.Database.EnsureDeleted();
    context.Database.EnsureCreated();

    Category cars = new() { Title = "Cars" };
    Category volga = new() { Title = "Volga", Parent = cars };
    Category lada = new() { Title = "Lada Granta", Parent = cars };
    Category moskv = new() { Title = "Moskvich", Parent = cars };

    Category gadgets = new() { Title = "Gadgets" };
    Category nb = new() { Title = "Notebook", Parent = gadgets };
    Category clock = new() { Title = "Digit Clock", Parent = gadgets };
    Category phone = new() { Title = "iPhone", Parent = gadgets };

    context.Categories.AddRange(cars, gadgets, volga, lada, moskv, nb, clock, phone);
    context.SaveChanges();
}