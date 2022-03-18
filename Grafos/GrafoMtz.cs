namespace Grafos
{
    public class GrafoMtz
    {
        private readonly int _tamano;
        private readonly int[,] _grafo;

        public GrafoMtz(int Tamanho)
        {
            _tamano = Tamanho;
            _grafo = _iniciarGrafo(Tamanho);
        }

        public void InserirArestaEspelhada(int x, int y)
        {
            _grafo[x, y] += 1;
            _grafo[y, x] += 1;
        }

        public void InserirAresta(int x1, int y1, int x2, int y2)
        {
            _grafo[x1, y1] += 1;
            _grafo[x2, y2] += 1;
        }

        public int[] ExplorarProfundidade(int VerticeInicial)
        {
            List<int> Visitados = new List<int>();
            _explorarProfundidade(Visitados, VerticeInicial);
            return Visitados.ToArray();
        }

        private void _explorarProfundidade(List<int> Visitados, int atual)
        {
            Visitados.Add(atual);

            for (int i = 0; i < _tamano; i++)
            {
                if (!Visitados.Any(a => a == i) && _grafo[atual, i] >= 1)
                    _explorarProfundidade(Visitados, i);
            }
        }

        private int[,] _iniciarGrafo(int t)
        {
            int[,] arr = new int[t, t];

            for (int i = 0; i < t; i++)
            {
                for (int j = 0; j < t; j++)
                {
                    arr[i, j] = 0;
                }
            }

            return arr;
        }
    }
}
