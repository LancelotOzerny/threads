namespace MatrixThread
{
    public partial class Form1 : Form
    {
        object locker = new();
        private List<Matrix> _matrixes = new List<Matrix>();
        static private Random rand = new Random();
        Multiplyer multiplyer = new Multiplyer(2);
       
        public Form1()
        {
            InitializeComponent();
        }

        private void AddMatrixes()
        {
            int size = rand.Next(2, 4);

            Matrix newMtx1 = new Matrix(size);
            _matrixes.Add(newMtx1);

            PrintMatrix(newMtx1, startMatrixes);
        }

        private void PrintMatrix(Matrix mtx, ListBox list)
        {
            lock (locker)
            {
                for (int i = 0; i < mtx.Size; i++)
                {
                    string values = "";
                    for (int j = 0; j < mtx.Size; j++)
                    {
                        values += $"{mtx[i, j]}\t";
                    }
                    list.Invoke(new Action(() => list.Items.Add(values)));
                    list.Invoke(new Action(() => list.Items.Add("")));
                }
                list.Invoke(new Action(() => list.Items.Add("_____________________")));
                list.Invoke(new Action(() => list.Items.Add("")));
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            AddMatrixes();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            ResultValues.Items.Clear();
            multiplyer.Multiply(_matrixes, this);
        }


        private void clear_btn_Click(object sender, EventArgs e)
        {
            _matrixes.Clear();
            startMatrixes.Items.Clear();
            ResultValues.Items.Clear();
        }

        class Multiplyer
        {
            private int threadCounts = 0;
            private int maxThreadCounts;

            public Multiplyer(int threadCounts)
            {
                this.maxThreadCounts = threadCounts;
            }

            public void Multiply(List<Matrix> _matrixes, Form1 form)
            {
                for (int i = 0; i < _matrixes.Count; ++i)
                {
                    Thread thread = new Thread((matrix) =>
                    {
                        while (threadCounts >= maxThreadCounts)
                        {
                            Thread.Sleep(100);
                        }

                        threadCounts++;
                        foreach (Matrix mtx in _matrixes)
                        {
                            Matrix m1 = (Matrix)matrix;
                            if (m1.Size == mtx.Size)
                            {
                                Matrix result = m1 * mtx;
                                form.PrintMatrix(result, form.ResultValues);
                                Thread.Sleep(1000);
                            }
                        }
                        threadCounts--;
                    });
                    thread.Start(_matrixes[i]);
                }
            }
        }
    }
}