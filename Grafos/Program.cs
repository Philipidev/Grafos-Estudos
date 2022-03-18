using Grafos;

Grafo grafo = new Grafo(10);

grafo.InserirAresta(1, 2);
grafo.InserirAresta(2, 1);
grafo.InserirAresta(2, 3);
grafo.InserirAresta(3, 2);
grafo.InserirAresta(5, 3);
grafo.InserirAresta(3, 5);

int[] visitados = grafo.ExplorarProfundidade(2);

foreach (var v in visitados)
    Console.WriteLine("Visitou {0}", v);