// string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
// string[] pedidos = orderStream.Split(',');

// Array.Sort(pedidos);

// foreach (var pedido in pedidos)
// {
//     if (!(pedido.Length == 4)) {
//         Console.WriteLine(pedido + "    -   Error");
//     } else
//     Console.WriteLine(pedido);
// } manipulação de strings e chars

// string customerName = "Ms. Barros"; 
// // interpolação de strings
// string currentProduct = "Magic Yield";
// int currentShares = 2975000;
// decimal currentReturn = 0.1275m;
// decimal currentProfit = 55000000.0m;

// string newProduct = "Glorious Future";
// decimal newReturn = 0.13125m;
// decimal newProfit = 63000000.0m;

// // Your logic here

// Console.WriteLine("Here's a quick comparison:\n");

// string comparisonMessage = @$"Dear {customerName},
// As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.

// Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.

// Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.

// Here's a quick comparison:

// " + currentProduct.PadRight(20) + @$"{currentReturn:P}     {currentProfit:C} 
// " + newProduct.PadRight(20) + $"{newReturn:P}     {newProfit:C}" ;



// Console.WriteLine(comparisonMessage);