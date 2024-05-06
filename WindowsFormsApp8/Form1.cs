using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public class Edge
        {
            private int from, to;
            private Pen color;

            public Edge(int from, int to)
            {
                this.from = from;
                this.to = to;
                this.color = new Pen(Color.DarkBlue);
            }

            public void SetColor(Color new_color)
            {
                color = new Pen(new_color);
            }

            public Pen GetColor()
            {
                return color;
            }

            public int GetFrom()
            {
                return from;
            }

            public int GetTo()
            {
                return to;
            }
        }

        List<Edge> Edges = new List<Edge>();
        List<RoundButton> Vertexes = new List<RoundButton>();
        List<List<int>> Graph = new List<List<int>>();
        List<int> used = new List<int>();
        List<Point> nums_pos = new List<Point>();
        int free_id = 1;
        int clicked_id = -1;
        int first_id = -1;
        int second_id = -1;
        bool is_add_vertex = false;
        bool is_remove_vertex = false;
        bool is_add_edge = false;
        bool is_dfs = false;
        bool is_bfs = false;
        bool clicked = false;
        Point iClick = new Point();
        private Graphics graphics;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;

        public Form1()
        {
            InitializeComponent();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            // Настроим фильтры файлов
            openFileDialog.Filter = "JSON files (*.json)|*.json";
            saveFileDialog.Filter = "JSON files (*.json)|*.json";
        }
        public struct VertexCoordinates
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
        public class GraphData
        {
            public List<VertexData> Vertexes { get; set; }
            public List<EdgeData> Edges { get; set; }
        }

        public class VertexData
        {
            public int Id { get; set; }
            public VertexCoordinates Coordinates { get; set; }
        }

        public class EdgeData
        {
            public int From { get; set; }
            public int To { get; set; }
        }

        // Вспомогательные функции

        private Point ConvertFromChildToForm(int x, int y, Control control)
        {
            Point p = new Point(x, y);
            control.Location = p;
            return p;
        }

        private int GetIdByNum(int num)
        {
            int id = -1;
            for (int i = 0; i < Vertexes.Count; ++i)
            {
                if (Vertexes[i].Text == num.ToString())
                {
                    id = i;
                }
            }
            return id;
        }

        private int GetEdgeId(int from, int to)
        {
            for (int i = 0; i < Edges.Count; ++i)
            {
                int v = GetIdByNum(Edges[i].GetFrom());
                int u = GetIdByNum(Edges[i].GetTo());
                if ((u == from && v == to) || (u == to && v == from))
                {
                    return i;
                }
            }
            return 0;
        }

        private void DrawEdges()
        {
            graphics = CreateGraphics();
            for (int i = 0; i < Edges.Count; ++i)
            {
                int first_vertex_id = GetIdByNum(Edges[i].GetFrom());
                int second_vertex_id = GetIdByNum(Edges[i].GetTo());
                Point first = new Point(Vertexes[first_vertex_id].Left + 25, Vertexes[first_vertex_id].Top + 25);
                Point second = new Point(Vertexes[second_vertex_id].Left + 25, Vertexes[second_vertex_id].Top + 25);
                graphics.DrawLine(Edges[i].GetColor(), first, second);
            }
        }

        private void DrawNums()
        {
            for (int i = 0; i < nums_pos.Count; ++i)
            {
                graphics.DrawString((i + 1).ToString(), new Font("Arial", 12), new SolidBrush(Color.DarkBlue), nums_pos[i]);
            }
        }

        public void ResetClicked(int cl = -1)
        {
            clicked_id = cl;
            first_id = -1;
            second_id = -1;
            is_add_edge = false;
            is_add_vertex = false;
            is_remove_vertex = false;
            clicked = false;
            is_dfs = false;
            is_bfs = false;
            AddEdgeBtn.BackColor = Color.Gainsboro;
            AddVertexBtn.BackColor = Color.Gainsboro;
            RemoveVertexBtn.BackColor = Color.Gainsboro;
        }

        private void ToDeafult()
        {
            for (int i = 0; i < Vertexes.Count; ++i)
            {
                Vertexes[i].BackColor = Color.DarkBlue;
            }
            for (int i = 0; i < Edges.Count; ++i)
            {
                Edges[i].SetColor(Color.DarkBlue);
            }
            this.Refresh();
            DrawEdges();
        }

        private void RemoveVertex(object sender, EventArgs e)
        {
            int id = -1;
            for (int i = 0; i < Vertexes.Count; ++i)
            {
                if (sender.Equals(Vertexes[i])) {
                    id = i;
                    break;
                }
            }
            List<Edge> remove_edges = new List<Edge>();
            for (int i = 0; i < Edges.Count; ++i)
            {
                int first = GetIdByNum(Edges[i].GetFrom());
                int second = GetIdByNum(Edges[i].GetTo());
                if (first == id || second == id)
                {
                    remove_edges.Add(Edges[i]);
                }
            }
            for (int i = 0; i < remove_edges.Count; ++i)
            {
                Edges.Remove(remove_edges[i]);
            }

            this.Controls.Remove(Vertexes[id]);
            Vertexes.Remove(Vertexes[id]);
        }

        private void AddEdge(object sender, EventArgs e)
        {
            if (first_id == -1)
            {
                for (int i = 0; i < Vertexes.Count(); ++i)
                {
                    if (sender.Equals(Vertexes[i]))
                    {
                        first_id = Convert.ToInt32(Vertexes[i].Text);
                        Vertexes[i].BackColor = Color.HotPink;
                    }
                }
            }
            else
            {
                for (int i = 0; i < Vertexes.Count(); ++i)
                {
                    if (sender.Equals(Vertexes[i]))
                    {
                        second_id = Convert.ToInt32(Vertexes[i].Text);
                        Vertexes[i].BackColor = Color.HotPink;
                    }
                }
                Edges.Add(new Edge(first_id, second_id));
                first_id = -1;
                second_id = -1;
                ToDeafult();
            }
        }

        private void StartDfs(object sender, EventArgs e)
        {
            ResetClicked();
            ToDeafult();
            int dfs_id = -1;
            nums_pos.Clear();
            for (int i = 0; i < Vertexes.Count(); ++i)
            {
                if (sender.Equals(Vertexes[i]))
                {
                    dfs_id = Convert.ToInt32(Vertexes[i].Text);
                    Vertexes[i].BackColor = Color.HotPink;
                }
            }
            this.Refresh();
            int x = Vertexes[GetIdByNum(dfs_id)].Left + 18;
            int y = Vertexes[GetIdByNum(dfs_id)].Top - 15;
            nums_pos.Add(new Point(x, y));
            DrawNums();
            DrawEdges();
            UpdateGraph();
            Thread.Sleep(500);
            dfs(GetIdByNum(dfs_id));
            is_dfs = false;
        }

        private void StartBfs(object sender, EventArgs e)
        {
            ResetClicked();
            ToDeafult();
            int bfs_id = -1;
            nums_pos.Clear();
            for (int i = 0; i < Vertexes.Count(); ++i)
            {
                if (sender.Equals(Vertexes[i]))
                {
                    bfs_id = Convert.ToInt32(Vertexes[i].Text);
                    Vertexes[i].BackColor = Color.HotPink;
                }
            }
            this.Refresh();
            int x = Vertexes[GetIdByNum(bfs_id)].Left + 18;
            int y = Vertexes[GetIdByNum(bfs_id)].Top - 15;
            nums_pos.Add(new Point(x, y));
            DrawNums();
            DrawEdges();
            UpdateGraph();
            Thread.Sleep(500);
            bfs(GetIdByNum(bfs_id));
            is_bfs = false;
        }

        private void UpdateGraph()
        {
            Graph.Clear();
            used.Clear();
            int n = Vertexes.Count;
            for (int i = 0; i < n; ++i)
            {
                List<int> tmp = new List<int>();
                for (int j = 0; j < n; ++j)
                {
                    tmp.Add(0);
                }
                Graph.Add(tmp);
                used.Add(0);
            }
            for (int i = 0; i < Edges.Count; ++i)
            {
                int first_vertex_id = GetIdByNum(Edges[i].GetFrom());
                int second_vertex_id = GetIdByNum(Edges[i].GetTo());
                Graph[first_vertex_id][second_vertex_id] = 1;
                Graph[second_vertex_id][first_vertex_id] = 1;
            }
        }

        private void dfs(int v)
        {
            used[v] = 1;
            for (int u = 0; u < Graph[v].Count; ++u)
            {
                if (Graph[v][u] == 1 && used[u] != 1)
                {

                    Edges[GetEdgeId(v, u)].SetColor(Color.HotPink);
                    DrawEdges();
                    Thread.Sleep(500);
                    Vertexes[u].BackColor = Color.HotPink;
                    this.Refresh();
                    int x = Vertexes[u].Left + 18;
                    int y = Vertexes[u].Top - 15;
                    nums_pos.Add(new Point(x, y));
                    DrawNums();
                    DrawEdges();
                    Thread.Sleep(500);
                    dfs(u);
                }
            }
        }

        private void bfs(int s)
        {
            List<int> q = new List<int>();
            used[s] = 1;
            q.Add(s);
            while (q.Count != 0)
            {
                int v = q[0];
                q.Remove(q[0]);
                for (int i = 0; i < Graph[v].Count; ++i)
                {
                    if (Graph[v][i] != 0)
                    {
                        int to = i;
                        if (used[to] != 1)
                        {
                            used[to] = 1;
                            q.Add(to);
                            Edges[GetEdgeId(v, to)].SetColor(Color.HotPink);
                            DrawEdges();
                            Thread.Sleep(500);
                            Vertexes[to].BackColor = Color.HotPink;
                            this.Refresh();
                            int x = Vertexes[to].Left + 18;
                            int y = Vertexes[to].Top - 15;
                            nums_pos.Add(new Point(x, y));
                            DrawNums();
                            DrawEdges();
                            Thread.Sleep(500);
                        }
                    }
                }
            }
        }

        // Обработка кликов мышью

        private void Form_MouseClick(object sender, MouseEventArgs e)
        {
            if (is_add_vertex)
            {
                RoundButton tmp = new RoundButton();
                tmp.Text = free_id.ToString();
                tmp.Width = 50;
                tmp.Height = 50;
                tmp.BackColor = Color.DarkBlue;
                tmp.ForeColor = Color.White;
                tmp.MouseDown += Vertex_MouseDown;
                tmp.MouseUp += Vertex_MouseUp;
                tmp.MouseMove += Vertex_MouseMove;
                tmp.MouseClick += Vertex_MouseClick;
                tmp.Location = new Point(e.X - 25, e.Y - 25);
                this.Controls.Add(tmp);
                Vertexes.Add(tmp);
                ++free_id;
                DrawEdges();
            }
        }

        private void Vertex_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) // Сменить на правую
            {
                bFSToolStripMenuItem.Tag = sender;
                dFSToolStripMenuItem.Tag = sender;
                removeVertexToolStripMenuItem.Tag = sender;
                contextMenuStrip1.Show(this, MousePosition);
            }
            if (is_bfs)
            {
                StartBfs(sender, e);
            }
            if (is_dfs)
            {
                StartDfs(sender, e);
            }
            if (is_add_edge)
            {
                AddEdge(sender, e);
            }
            if (is_remove_vertex)
            {
                RemoveVertex(sender, e);
            }
        }

        private void Vertex_MouseDown(object sender, MouseEventArgs e)
        {
            if (!is_add_edge && !is_dfs && !is_bfs && !is_remove_vertex)
            {
                ResetClicked();
                ToDeafult();
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    for (int i = 0; i < Vertexes.Count(); ++i)
                    {
                        if (sender.Equals(Vertexes[i]))
                        {
                            clicked_id = i;
                            Vertexes[clicked_id].BackColor = Color.HotPink;
                        }
                    }
                    Point p = ConvertFromChildToForm(e.X, e.Y, Vertexes[clicked_id]);
                    iClick.X = e.X;
                    iClick.Y = e.Y;
                    clicked = true;
                }
            }
        }

        private void Vertex_MouseMove(object sender, MouseEventArgs e)
        {
            if (clicked)
            {
                Point p = new Point();
                p.X = e.X + Vertexes[clicked_id].Left;
                p.Y = e.Y + Vertexes[clicked_id].Top;

                // Проверка границ формы
                p.X = Math.Max(25, Math.Min(p.X, this.ClientSize.Width - Vertexes[clicked_id].Width + 27));
                p.Y = Math.Max(25, Math.Min(p.Y, this.ClientSize.Height - Vertexes[clicked_id].Height + 27));

                Vertexes[clicked_id].Left = p.X - iClick.X;
                Vertexes[clicked_id].Top = p.Y - iClick.Y;
                graphics.Clear(Color.White);
                DrawEdges();
            }
        }

        private void Vertex_MouseUp(object sender, MouseEventArgs e)
        {
            clicked = false;
        }

        private void AddVertexBtn_Click(object sender, EventArgs e)
        {
            ResetClicked();
            ToDeafult();
            AddVertexBtn.BackColor = Color.CornflowerBlue;
            is_add_vertex = true;
        }

        private void RemoveVertexBtn_Click(object sender, EventArgs e)
        {
            ResetClicked(clicked_id);
            ToDeafult();
            RemoveVertexBtn.BackColor = Color.CornflowerBlue;
            is_remove_vertex = true;
        }

        private void AddEdgeBtn_Click(object sender, EventArgs e)
        {
            ResetClicked();
            ToDeafult();
            AddEdgeBtn.BackColor = Color.CornflowerBlue;
            is_add_edge = true;
        }

        private void DfsBtn_Click(object sender, EventArgs e)
        {
            ToDeafult();
            ResetClicked();
            is_dfs = true;
        }

        private void BfsBtn_Click(object sender, EventArgs e)
        {
            ToDeafult();
            ResetClicked();
            is_bfs = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddVertexBtn.BackColor = Color.Gainsboro;
            RemoveVertexBtn.BackColor = Color.Gainsboro;
            AddEdgeBtn.BackColor = Color.Gainsboro;
            DfsBtn.BackColor = Color.Gainsboro;
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            ToDeafult();
            ResetClicked();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Edges.Clear();
            for (int i = 0; i < Vertexes.Count; ++i)
            {
                this.Controls.Remove(Vertexes[i]);
            }
            Vertexes.Clear();
            free_id = 1;
            ToDeafult();
            ResetClicked();
        }
        private void ExportToJson()
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog.FileName;
                var graphData = new
                {
                    Vertexes = Vertexes.Select(v => new { Id = v.Text, Coordinates = new VertexCoordinates { X = v.Left, Y = v.Top } }).ToList(),
                    Edges = Edges.Select(e => new { From = e.GetFrom(), To = e.GetTo() }).ToList()
                };

                string json = JsonConvert.SerializeObject(graphData, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(filename, json);
            }
        }
        private void ImportFromJson()
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog.FileName;
                string json = File.ReadAllText(filename);

                try
                {
                    var graphData = JsonConvert.DeserializeObject<GraphData>(json);

                    ClearBtn_Click(null, null); // Очищаем текущий граф

                    foreach (var vertex in graphData.Vertexes)
                    {
                        RoundButton tmp = new RoundButton();
                        tmp.Text = vertex.Id.ToString();
                        tmp.Width = 50;
                        tmp.Height = 50;
                        tmp.BackColor = Color.DarkBlue;
                        tmp.ForeColor = Color.White;
                        tmp.MouseDown += Vertex_MouseDown;
                        tmp.MouseUp += Vertex_MouseUp;
                        tmp.MouseMove += Vertex_MouseMove;
                        tmp.MouseClick += Vertex_MouseClick;
                        tmp.Location = new Point(vertex.Coordinates.X, vertex.Coordinates.Y);
                        this.Controls.Add(tmp);
                        Vertexes.Add(tmp);
                        free_id = Math.Max(free_id, vertex.Id + 1);
                    }

                    foreach (var edge in graphData.Edges)
                    {
                        Edges.Add(new Edge(edge.From, edge.To));
                    }

                    DrawEdges();
                    ToDeafult();
                }
                catch (JsonException ex)
                {
                    MessageBox.Show("Ошибка при импорте файла: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void SaveGraphImage(string filename)
        {
            // Создаем Bitmap с размером, равным размеру формы
            Bitmap bmp = new Bitmap(ClientSize.Width, ClientSize.Height);
            // Создаем Graphics из Bitmap
            Graphics g = Graphics.FromImage(bmp);
            // Отрисовываем форму на Graphics
            this.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            // Сохраняем Bitmap в файл
            bmp.Save(filename, ImageFormat.Png);
        }

        private void ExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportToJson();
        }

        private void ImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportFromJson();
        }

        private void dFSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoundButton clickedVertex = (RoundButton)((ToolStripMenuItem)sender).Tag;
            int vertexNum = int.Parse(clickedVertex.Text);
            int vertexId = GetIdByNum(vertexNum);
            StartDfs(Vertexes[vertexId], null);
        }

        private void bFSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoundButton clickedVertex = (RoundButton)((ToolStripMenuItem)sender).Tag;
            int vertexNum = int.Parse(clickedVertex.Text);
            int vertexId = GetIdByNum(vertexNum);
            StartBfs(Vertexes[vertexId], null);
        }

        private void removeVertexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Получаем вершину, на которой кликнули правой кнопкой мыши
            RoundButton clickedVertex = (RoundButton)((ToolStripMenuItem)sender).Tag;
            int vertexId = Vertexes.IndexOf(clickedVertex);

            // Удаляем вершину и связанные с ней ребра
            if (vertexId >= 0 && vertexId < Vertexes.Count)
            {
                RemoveVertex(clickedVertex, null);
            }
        }

        /*
        private void SaveToPNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog.FileName;
                SaveGraphImage(filename);
            }
        }
        */
    }

    public class RoundButton : Button
    {
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(2, 2, ClientSize.Width - 5, ClientSize.Height - 5);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(e);
        }
    }
}
