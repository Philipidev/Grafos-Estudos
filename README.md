# Grafos-Estudos
Lista de exercicios 2:

Link abaixo irá direcionar para o arquivo de classe criado para a lista 2
[Classe Lista2](https://github.com/Philipidev/Grafos-Estudos/tree/main/Grafos/Grafos%20Lista%202)

Contudo segue código abaixo para visualização também

Para rodar o código basta ter o .Net Core 6.0 com o C# 10 instalado, ou com a IDE do Visual Studio 2022 ou com compiladores online

```cs
public class GrafoLista2
    {
        private int[,] grafo = new int[1, 1];
        private List<string> verticesDesejados = new();
        private int numVertices = 0;
        private int tipoGrafo = 0;

        private void InsereArestaPonderadoNaoDirecionado(int[,] grafo, int origem, int destino)
        {
            Console.WriteLine("Informe o peso na aresta: " + origem + " => " + destino);
            int peso = Convert.ToInt32(Console.ReadLine());
            grafo[origem, destino] = peso;
            grafo[destino, origem] = peso;
        }

        private void InsereArestaNaoPonderadoDirecionado(int[,] grafo, int origem, int destino)
        {
            grafo[origem, destino] = 1;
        }

        private void InsereArestaNaoPonderadoNaoDirecionado(int[,] grafo, int origem, int destino)
        {
            grafo[origem, destino] = 1;
            grafo[destino, origem] = 1;
        }

        private void InsereArestaPonderadoDirecionado(int[,] grafo, int origem, int destino)
        {
            Console.WriteLine("Informe o peso na aresta: " + origem + " => " + destino);
            int peso = Convert.ToInt32(Console.ReadLine());
            grafo[origem, destino] = peso;
        }

        private int ObterOrigem(string textoToSplit)
        {
            return textoToSplit.ElementAt(0);
        }

        private int ObterDestino(string textoToSplit)
        {
            return textoToSplit.ElementAt(1);
        }

        private void DefineGrafo()
        {
            Console.WriteLine("Escolha a definição do Grafo");
            Console.WriteLine("1) Grafo direcionado não-ponderado");
            Console.WriteLine("2) Grafo não direcionado não ponderado");
            Console.WriteLine("3) Grafo direcionado ponderado");
            Console.WriteLine("4) Grafo não-direcionado ponderado");

            tipoGrafo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Qual a quantidade de vértices? ");
            numVertices = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Em quais vértices deseja aresta? ");

            while (Console.ReadLine() != "N")
            {
                verticesDesejados.Add(Console.ReadLine());
                Console.WriteLine("Deseja inserir mais um vertice? [S:N]: ");
            }
        }

        private string ObterTipoGrafo(int indice)
        {
            string[] tipos = {
                "direcionado não-ponderado",
                "não direcionado não ponderado",
                "direcionado ponderado",
                "não-direcionado ponderado"
            };
            return tipos[indice];
        }

        public void IniciarExemploLista2()
        {
            while (Console.ReadLine() != "N")
            {
                DefineGrafo();
                grafo = new int[numVertices, numVertices];

                string[] vertices = verticesDesejados.ToArray();
                Console.WriteLine("Tipo: " + ObterTipoGrafo(tipoGrafo));

                for (int i = 0; i < vertices.Length; i++)
                {
                    int origem = ObterOrigem(vertices[i]);
                    int destino = ObterDestino(vertices[i]);

                    switch (tipoGrafo)
                    {
                        case 1:
                            InsereArestaNaoPonderadoDirecionado(grafo, origem, destino);
                            break;
                        case 2:
                            InsereArestaNaoPonderadoNaoDirecionado(grafo, origem, destino);
                            break;
                        case 3:
                            InsereArestaPonderadoDirecionado(grafo, origem, destino);
                            break;
                        case 4:
                            InsereArestaPonderadoNaoDirecionado(grafo, origem, destino);
                            break;
                        default:
                            break;
                    }

                }

                Console.WriteLine("Deseja reiniciar e testar com outro grafo? [S:N]: ");
            }
            Console.WriteLine(";) 👌👍");
        }
    }
```
