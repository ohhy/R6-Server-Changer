using System;
using System.IO;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Threading;

namespace R6_Server_Changer
{
    public partial class Form1 : Form
    {
        string uri;
        string[] servers = { "default", "eus", "cus", "scus", "wus", "sbr", "neu", "weu", "eas", "seas", "eau", "wja" };

        //파일 선택, 서버 선택
        bool SelectFile = false, SelectServer = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void file_path_Click(object sender, EventArgs e)
        {
            OpenFile_Dialog.Title = "R6 GameSettings.ini 파일을 열어주십시오";
            //서버 바꿀 파일 선택함
            if (OpenFile_Dialog.ShowDialog() == DialogResult.OK)
            {
                uri = (OpenFile_Dialog.FileName);

                SelectFile = true;
            }

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //서버 선택함
            selected_server.Text = servers[comboBox1.SelectedIndex];
            SelectServer = true;
        }



        private void select_server_Click(object sender, EventArgs e)
        {
            if (!SelectFile)
            {
                MessageBox.Show("파일을 선택하여 주십시오");
                return;
            }
            else if (!SelectServer)
            {
                MessageBox.Show("서버를 선택하여 주십시오");
                return;
            }

            //서버 변경함
            try
            {
                StreamReader sr = new StreamReader(uri);
                //설정파일 데이터값 저장 변수
                string file_text = sr.ReadToEnd();
                //읽었으니 닫음
                sr.Close();
                //서버 설정 부분 값
                int startIndex = (file_text.LastIndexOf("DataCenterHint")) + "DataCenterHint".Length + 1;
                //count만큼 제거할 변수
                int count = 0;
                //\n까지 반복함 count증가
                for (int i = startIndex; file_text[i] != '\n'; i++)
                {
                    count++;
                }

                //파일에서 count-1 크기만큼 지움(count는 \n까지 포함이라서)
                file_text = file_text.Remove(startIndex, count - 1);
                //서버 이름 삽입
                file_text = file_text.Insert(startIndex, servers[comboBox1.SelectedIndex]);
                //변경사항 쓰기위해 스트림라이터 오픈
                StreamWriter sw = new StreamWriter(uri);
                //변경사항 다시 씀
                sw.Write(file_text);
                //닫음
                sw.Close();
                MessageBox.Show("변경이 완료되었습니다");
            }
            catch (IOException)
            {
                MessageBox.Show("에러가 났습니다.");
            }
        }
        private void search_player_Click(object sender, EventArgs e)
        {
            try
            {
                string uri = "https://r6stats.com/stats/uplay/" + player_name.Text;
                var web = new HtmlWeb();
                var doc = web.Load(uri);

                string kill = "", death = "", kd = "", level = "", win;

                kill = doc.DocumentNode.SelectSingleNode(".//div[@class='col-md-3 col-xs-6 stat']")
                    .SelectSingleNode(".//div[@class='value']").InnerText;
                death = doc.DocumentNode.SelectNodes(".//div[@class='col-md-3 col-xs-6 stat']")[1]
                    .SelectSingleNode(".//div[@class='value']").InnerText;
                kd = doc.DocumentNode.SelectNodes(".//div[@class='col-md-3 col-xs-6 stat']")[2]
                    .SelectSingleNode(".//div[@class='value']").InnerText;
                level = doc.DocumentNode.SelectNodes(".//div[@class='col-md-3 col-xs-6 stat']")[7]
                    .SelectSingleNode(".//div[@class='value']").InnerText;
                win = doc.DocumentNode.SelectNodes(".//div[@class='col-md-3 col-xs-6 stat']")[5]
                    .SelectSingleNode(".//div[@class='value']").InnerText;

                kill = kill.Replace("\n", "");
                death = death.Replace("\n", "");
                kd = kd.Replace("\n", "");
                level = level.Replace("\n", "");
                win = win.Replace("\n", "");

                killed_n.Text = kill;
                death_n.Text = death;
                kill_death_n.Text = kd;
                level_n.Text = level;
                win_n.Text = win;
            }
            catch(NullReferenceException)
            {
                MessageBox.Show($"{player_name.Text}는 uplay유저가 아니거나\n없는 플레이어입니다");
            }
        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            Form2 help_form = new Form2();
            help_form.ShowDialog();
        }
    }
}
