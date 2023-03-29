BottleOfWater bottle = new BottleOfWater("Borsec", 500, false);

Console.WriteLine(bottle.Vendor);
Console.WriteLine(bottle.Capacity);
bottle.TakeASip(600);
Console.WriteLine(bottle.Capacity);
bottle.TakeASip(600);