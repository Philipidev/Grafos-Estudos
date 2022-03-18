using Grafos;

GrafoMtz grafo = new GrafoMtz(10);

grafo.InserirArestaEspelhada(1, 2);
grafo.InserirArestaEspelhada(2, 1);
grafo.InserirArestaEspelhada(2, 3);
grafo.InserirArestaEspelhada(3, 2);
grafo.InserirArestaEspelhada(5, 3);
grafo.InserirArestaEspelhada(3, 5);

int[] visitados = grafo.ExplorarProfundidade(2);

foreach (var v in visitados)
    Console.WriteLine("Visitou {0}", v);