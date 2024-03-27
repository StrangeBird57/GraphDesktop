using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        bool is_add_edge = false;
        bool is_dfs = false;
        bool clicked = false;
        Point iClick = new Point();
        private Graphics graphics;

        public Form1()
        {
            InitializeComponent();
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
            clicked = false;
            is_dfs = false;
            AddEdgeBtn.BackColor = Color.Gainsboro;
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

        // Обработка кликов мышью

        private void Form_MouseClick(object sender, MouseEventArgs e)
        {
            ToDeafult();
            ResetClicked();
        }

        private void Vertex_MouseClick(object sender, EventArgs e)
        {
            if (is_dfs)
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
            if (is_add_edge)
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
        }

        private void Vertex_MouseDown(object sender, MouseEventArgs e)
        {
            if (!is_add_edge && !is_dfs)
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
                /*if (p.X <= this.Width && p.Y <= this.Height)
                {
                    Vertexes[clicked_id].Left = p.X - iClick.X;
                    Vertexes[clicked_id].Top = p.Y - iClick.Y;
                    graphics.Clear(Color.White);
                    DrawEdges();
                }*/
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
            tmp.Location = new Point(100, 100);
            this.Controls.Add(tmp);
            Vertexes.Add(tmp);
            ++free_id;
            DrawEdges();
        }

        private void RemoveVertexBtn_Click(object sender, EventArgs e)
        {
            ResetClicked(clicked_id);
            ToDeafult();
            if (clicked_id != -1)
            {
                List<Edge> remove_edges = new List<Edge>();
                for (int i = 0; i < Edges.Count; ++i)
                {
                    int first = GetIdByNum(Edges[i].GetFrom());
                    int second = GetIdByNum(Edges[i].GetTo());
                    if (first == clicked_id || second == clicked_id)
                    {
                        remove_edges.Add(Edges[i]);
                    }
                }
                for (int i = 0; i < remove_edges.Count; ++i)
                {
                    Edges.Remove(remove_edges[i]);
                }

                this.Controls.Remove(Vertexes[clicked_id]);
                Vertexes.Remove(Vertexes[clicked_id]);
                ResetClicked();
                ToDeafult();
            }
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
            /*if (clicked_id != -1)
            {
                Vertexes[clicked_id].BackColor = Color.DarkBlue;
                clicked_id = -1;
            }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddVertexBtn.BackColor = Color.Gainsboro;
            RemoveVertexBtn.BackColor = Color.Gainsboro;
            AddEdgeBtn.BackColor = Color.Gainsboro;
            DfsBtn.BackColor = Color.Gainsboro;
        }
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
