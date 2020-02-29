using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp11111
{
    public partial class Form1 : Form
    {
        private List<string> _list1;
        private List<string> _list2;

        public Form1()
        {
            InitializeComponent();
            CreateList();
            RecoverList();
            SetSelectionMode();
            GameLoseDefault();
            GameStartDefault();
        }

        private void BtnBack_Click(object sender, System.EventArgs e)
        {
            string goat = "山羊";
            string farmer = "農夫";
            string veg = "蔬菜";
            string wolf = "野狼";
            BtnGo.Enabled = true;
            BtnBack.Enabled = false;
            LsbRight.Enabled = false;
            LsbLeft.Enabled = true;

            if ((string)LsbRight.SelectedItem == farmer)
            {
                _list2.Remove(farmer);
                _list1.Add(farmer);
                ChangeData();
            }
            else
            {
                string s_item = (string)LsbRight.SelectedItem;
                _list1.Add(farmer);
                _list2.Remove(farmer);
                _list1.Add(s_item);
                _list2.Remove(s_item);
                ChangeData();
            }

            if (_list2.Contains(wolf) && _list2.Contains(goat))
            {
                MessageBox.Show("菜被羊吃了");
                RecoverList();
                CreateList();
                ChangeData();
                GameLoseDefault();
            }

            if (_list2.Contains(goat) && _list2.Contains(veg))
            {
                MessageBox.Show("菜被羊吃了");
                RecoverList();
                CreateList();
                ChangeData();
                GameLoseDefault();
            }
        }

        private void BtnGo_Click(object sender, System.EventArgs e)
        {
            string goat = "山羊";
            string farmer = "農夫";
            string veg = "蔬菜";
            string wolf = "野狼";
            LsbLeft.Enabled = false;
            LsbRight.Enabled = true;
            BtnGo.Enabled = false;
            BtnBack.Enabled = true;

            if ((string)LsbLeft.SelectedItem == farmer)
            {
                _list1.Remove(farmer);
                _list2.Add(farmer);
                ChangeData();
            }
            else
            {
                string s_item = (string)LsbLeft.SelectedItem;
                _list1.Remove(farmer);
                _list2.Add(farmer);
                _list1.Remove(s_item);
                _list2.Add(s_item);
                ChangeData();
            }

            if (_list1.Contains(wolf) && _list1.Contains(goat))
            {
                MessageBox.Show("羊被狼吃了");
                RecoverList();
                CreateList();
                ChangeData();
                GameLoseDefault();
            }

            if (_list1.Contains(goat) && _list1.Contains(veg))
            {
                MessageBox.Show("菜被吃了！失敗！！！");
                RecoverList();
                CreateList();
                ChangeData();
                GameLoseDefault();
            }

            if (_list1.Contains(goat) && _list1.Contains(wolf) && _list1.Contains(veg))
            {
                MessageBox.Show("菜被羊吃了，菜被羊吃了");
                RecoverList();
                CreateList();
                ChangeData();
                GameLoseDefault();
            }

            if (_list2.Count == 4)
            {
                MessageBox.Show("恭喜過河");
                RecoverList();
                CreateList();
                ChangeData();
                GameLoseDefault();
                MessageBox.Show("再來玩一次吧");
            }
        }

        private void BtnReset_Click(object sender, System.EventArgs e)
        {
            RecoverList();
            CreateList();
            ChangeData();
            GameLoseDefault();
        }

        private void ChangeData()
        {
            LsbLeft.DataSource = null;
            LsbRight.DataSource = null;
            LsbLeft.DataSource = _list1;
            LsbRight.DataSource = _list2;
        }

        private void CreateList()
        {
            _list1 = new List<string>() { "山羊", "野狼", "農夫", "蔬菜" };
            _list2 = new List<string>();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            RecoverList();
            CreateList();
            ChangeData();
            MessageBox.Show("農夫過河開始囉");
            GameLoseDefault();
        }

        private void GameLoseDefault()
        {
            LsbLeft.Enabled = true;
            LsbRight.Enabled = false;
            BtnGo.Enabled = true;
            BtnBack.Enabled = false;
        }

        private void GameStartDefault()
        {
            LsbLeft.Enabled = false;
            LsbRight.Enabled = true;
            BtnGo.Enabled = false;
            BtnBack.Enabled = true;
        }

        private void RecoverList()
        {
            _list1 = null;
            _list2 = null;
        }

        private void SetSelectionMode()
        {
            LsbLeft.SelectionMode = SelectionMode.One;
            LsbRight.SelectionMode = SelectionMode.One;
        }
    }
}