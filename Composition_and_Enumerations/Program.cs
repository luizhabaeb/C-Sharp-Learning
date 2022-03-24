﻿//Na aula fazemos a conversão de string para enumeração assim:

// OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
// Mas, dependendo da versão do compilador C#, isso pode dar problema. Se for o caso, por favor tente deste jeito:

// OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");
//Se mesmo assim ainda tiver dando erro, há ainda uma terceira forma:

//OrderStatus os;
//Enum.TryParse("Delivered", out os);

