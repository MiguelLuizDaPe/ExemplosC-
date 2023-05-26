List<int> numeros = new List<int>{1,2,3,4,5};

//não tem condição, então retorna o primeir ae jegue
int primeiroNumero = numeros.FirstOrDefault();
Console.WriteLine(primeiroNumero);

//retorna o primeiro valor maior que 3, ou seja o 4
int primeiroNumeroMaiorQueTres = numeros.FirstOrDefault(n => n > 3);
Console.WriteLine(primeiroNumeroMaiorQueTres);

//Retorna o 0 pq não achou o que se encaixava no padrão de pequisa então mandou um default
int primeiroNumeroMaiorQueCinco = numeros.FirstOrDefault(n => n > 5);
Console.WriteLine(primeiroNumeroMaiorQueCinco);

//não achou o que foi pedido então retornou o elemento que foi passado por parametro que era 100
int primeiroNumeroMaiorQueSete = numeros.FirstOrDefault(n => n > 7, 100);
Console.WriteLine(primeiroNumeroMaiorQueSete);

