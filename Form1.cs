using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AfterProcessing
{
    public partial class Form1 : Form
    {
        string[] org_lines;
        public Form1()
        {
            InitializeComponent();
            selMachineType.SelectedIndex = 1;
            txt_progname.Text = "Axis_Ctrl";
            chkbx_4.Checked = true;
            chkbx_5.Checked = true;
        }

        public int Axis_Data(string data,
                            ref string data4,
                            ref string sorg4,
                            ref string data5,
                            ref string sorg5)
        {
            string regexstr_4 = @"[.0-9\s]+["+txt_4.Text.ToUpper() + txt_4.Text.ToLower()+ @"](-?)(\d+)?(((\.\d+))|(\d+))(\.?)";
            string regexstr_5 = @"[.0-9\s]+["+txt_5.Text.ToUpper() + txt_5.Text.ToLower() + @"](-?)(\d+)?(((\.\d+))|(\d+))(\.?)";
            int flag = 0;
            try
            {
                if(data.Contains(";"))
                {
                    data = data.Substring(0, data.IndexOf(";"));
                }
                MatchCollection mc = Regex.Matches(data, regexstr_4);
                if(mc.Count==1)
                {
                    string temp = mc[0].Value;
                    if (temp.Contains(txt_4.Text.ToUpper() + "-."))
                    {
                        //A-.
                        sorg4 = temp.Remove(0, temp.IndexOf(txt_4.Text.ToUpper()));
                        temp = temp.Replace(txt_4.Text.ToUpper() + "-.", txt_4.Text.ToUpper() + "-0.");
                        data4 = temp.Remove(0, temp.IndexOf(txt_4.Text.ToUpper()) + 1);
                        //data4 = float.Parse(temp);
                    }
                    else if (temp.Contains(txt_4.Text.ToLower() + "-."))
                    {
                        //a-.
                        sorg4 = temp.Remove(0, temp.IndexOf(txt_4.Text.ToLower()));
                        temp = temp.Replace(txt_4.Text.ToLower() + "-.", txt_4.Text.ToLower() + "-0.");
                        data4 = temp.Remove(0, temp.IndexOf(txt_4.Text.ToLower()) + 1);
                        //data4 = float.Parse(temp);
                    }
                    else if (temp.Contains(txt_4.Text.ToUpper() + "."))
                    {
                        //A.4
                        sorg4 = temp.Remove(0, temp.IndexOf(txt_4.Text.ToUpper()));
                        temp = temp.Replace(txt_4.Text.ToUpper()+".", txt_4.Text.ToUpper() + "0.");
                        data4 = temp.Remove(0, temp.IndexOf(txt_4.Text.ToUpper()) + 1);
                        //data4 = float.Parse(temp);
                    }
                    else if (temp.Contains(txt_4.Text.ToLower() + "."))
                    {
                        //a.4
                        sorg4 = temp.Remove(0, temp.IndexOf(txt_4.Text.ToLower()));
                        temp = temp.Replace(txt_4.Text.ToLower() + ".", txt_4.Text.ToLower() + "0.");
                        data4 = temp.Remove(0, temp.IndexOf(txt_4.Text.ToLower()) + 1);
                        //data4 = float.Parse(temp);
                    }
                    else if (temp.Contains(txt_4.Text.ToUpper()))
                    {
                        //A0.4
                        sorg4 = temp.Remove(0, temp.IndexOf(txt_4.Text.ToUpper()));
                        data4 = temp.Remove(0, temp.IndexOf(txt_4.Text.ToUpper()) + 1);
                        //data4 = float.Parse(temp);
                    }
                    else if (temp.Contains(txt_4.Text.ToLower()))
                    { 
                        //a0.4
                        sorg4 = temp.Remove(0,temp.IndexOf(txt_4.Text.ToLower()));
                        data4 = temp.Remove(0, temp.IndexOf(txt_4.Text.ToLower()) + 1);
                        //data4 = float.Parse(temp);
                    }
                    else
                        return 0;
                    flag += 1;
                }
                mc = Regex.Matches(data, regexstr_5);
                if (mc.Count == 1)
                {
                    string temp = mc[0].Value;
                    if (temp.Contains(txt_5.Text.ToUpper() + "."))
                    {
                        sorg5 = temp.Remove(0, temp.IndexOf(txt_5.Text.ToUpper()));
                        temp = temp.Replace(txt_5.Text.ToUpper() + ".", txt_5.Text.ToUpper() + "0.");
                        data5 = temp.Remove(0, temp.IndexOf(txt_5.Text.ToUpper()) + 1);
                    }
                    else if (temp.Contains(txt_5.Text.ToLower() + "."))
                    {
                        sorg5 = temp.Remove(0, temp.IndexOf(txt_5.Text.ToLower()));
                        temp = temp.Replace(txt_5.Text.ToLower() + ".", txt_5.Text.ToLower() + "0.");
                        data5 = temp.Remove(0, temp.IndexOf(txt_5.Text.ToLower()) + 1);
                    }
                    if (temp.Contains(txt_5.Text.ToUpper()))
                    {
                        sorg5 = temp.Remove(0, temp.IndexOf(txt_5.Text.ToUpper()));
                        data5 = temp.Remove(0, temp.IndexOf(txt_5.Text.ToUpper()) + 1);
                    }
                    else if (temp.Contains(txt_5.Text.ToLower()))
                    {
                        sorg5 = temp.Remove(0, temp.IndexOf(txt_5.Text.ToLower()));
                        data5 = temp.Remove(0, temp.IndexOf(txt_5.Text.ToLower()) + 1);
                    }
                    else
                        return 0;
                    flag += 2;
                }
                return flag;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        private void ProcessBtn_Click(object sender, EventArgs e)
        {
            if (txt_file.Text == "")
            {
                MessageBox.Show("请选择文件！");
                return;
            }
            listbox_after.Items.Clear();
            listbox_after.Items.Add("Axis_Ctrl(A，B，C)");
            List<string> TempList = listbox_org.Items.OfType<string>().ToList() ;
            List<string> OrgList = new List<string>();
            int orgindex = 0;
            int insertCnt = 0;
            int A_Cnt = 0;
            int B_Cnt = 0;

            foreach (string data in TempList)
            {
                string data4 = "",data5= "";
                string sorg4 = "", sorg5 = "";
                switch(Axis_Data(data,ref data4, ref sorg4, ref data5,ref sorg5))
                {                    
                    case 1:                        
                        if (chkbx_4.Checked)
                        {
                            if(selMachineType.Text == "fanuc")
                                listbox_after.Items.Add("G65P"+ txt_progname.Text + txt_4.Text + data4);
                            else if(selMachineType.Text == "siemens")
                                listbox_after.Items.Add("Axis_Ctrl");
                        }
                        listbox_after.Items.Add(data.Replace(sorg4," "));
                        OrgList.Add(" ");
                        insertCnt++;
                        A_Cnt++;
                        break;
                    case 2:
                        if (chkbx_5.Checked)
                        {
                            if (selMachineType.Text == "fanuc")
                                listbox_after.Items.Add("G65P" + txt_progname.Text + txt_5.Text + data5);
                            else if (selMachineType.Text == "siemens")
                                listbox_after.Items.Add("Axis_Ctrl");
                        }
                        listbox_after.Items.Add(data.Replace(sorg5, " "));
                        OrgList.Add(" ");
                        insertCnt++;
                        B_Cnt++;
                        break;
                    case 3:
                        if (chkbx_4.Checked && chkbx_5.Checked)
                        {
                            if (selMachineType.Text == "fanuc")
                                listbox_after.Items.Add("G65P" + txt_progname.Text + 
                                                        txt_4.Text + data4 + 
                                                        txt_5.Text + data5);
                            else if (selMachineType.Text == "siemens")
                                listbox_after.Items.Add("Axis_Ctrl");
                        }
                        else if (chkbx_4.Checked)
                        {
                            if (selMachineType.Text == "fanuc")
                                listbox_after.Items.Add("G65P" + txt_progname.Text + txt_4.Text + data4);
                            else if (selMachineType.Text == "siemens")
                                listbox_after.Items.Add("Axis_Ctrl");
                        }
                        else if (chkbx_4.Checked)
                        {
                            if (selMachineType.Text == "fanuc")
                                listbox_after.Items.Add("G65P" + txt_progname.Text + txt_5.Text + data5);
                            else if (selMachineType.Text == "siemens")
                                listbox_after.Items.Add("Axis_Ctrl");
                        }
                        string tempdata = data.Replace(sorg4, "");
                        listbox_after.Items.Add(tempdata.Replace(sorg5, " "));
                        OrgList.Add(" ");
                        insertCnt++;
                        B_Cnt++;
                        A_Cnt++;
                        break;
                    default:
                        listbox_after.Items.Add(data);
                        break;
                }
                OrgList.Add(data);
            }
            listbox_org.Items.Clear();
            foreach (string line in OrgList)
            {
                listbox_org.Items.Add(line);
            }
            MessageBox.Show("4轴旋转次数："+A_Cnt+"\n5轴旋转次数："+B_Cnt);
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            // 指定打开文本文件（后缀名为txt）
            openDlg.Filter = "文本文件|*.*";
            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                // 读出文本文件的所以行
                string[] org_lines = File.ReadAllLines(openDlg.FileName);
                // 先清空textBox1
                listbox_org.Items.Clear();
                // 在textBox1中显示
                foreach (string line in org_lines)
                {
                    listbox_org.Items.Add(" " + line);
                }
                // 显示文件路径名
                txt_file.Text = openDlg.FileName;
            }
            else
            {
                return;
            }
        }

        private void Listbox_org_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                if (listbox_org.Items.Count == 0)
                    return;
                {
                    string s = this.listbox_org.Items[e.Index].ToString();

                    string data4="", data5="";
                    string sorg4="", sorg5 = "";
                    int flag = Axis_Data(s, ref data4,ref sorg4, ref data5,ref sorg5);
                    if (flag == 1||flag==2||flag==3)
                    {
                        e.Graphics.FillRectangle(new SolidBrush(Color.Green), e.Bounds);
                        e.Graphics.DrawString(s, this.Font, Brushes.Black, e.Bounds);
                        e.DrawFocusRectangle();
                    }
                    else
                        e.Graphics.DrawString(s, this.Font, Brushes.Black, e.Bounds);
                }
            }
            catch(Exception ex)
            {

            }
            
        }

        private void Listbox_after_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                string s = listbox_after.Items[e.Index].ToString();
                if (listbox_after.Items.Count == 0)
                    return;
                if (selMachineType.Text == "fanuc")
                {
                    if (s.Contains("G65P" + txt_progname.Text))
                    {
                        e.Graphics.FillRectangle(new SolidBrush(Color.Red), e.Bounds);
                        e.Graphics.DrawString(s, this.Font, Brushes.Black, e.Bounds);
                        e.DrawFocusRectangle();
                    }
                    else
                        e.Graphics.DrawString(s, this.Font, Brushes.Black, e.Bounds);
                }
                else if (selMachineType.Text == "siemens")
                {
                    if (s.Contains(txt_progname.Text))
                    {
                        e.Graphics.FillRectangle(new SolidBrush(Color.Red), e.Bounds);
                        e.Graphics.DrawString(s, this.Font, Brushes.Black, e.Bounds);
                        e.DrawFocusRectangle();
                    }
                    else
                        e.Graphics.DrawString(s, this.Font, Brushes.Black, e.Bounds);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            List<string> TempList = listbox_after.Items.OfType<string>().ToList();
            string path = txt_file.Text.ToString() + "_v2";
            File.WriteAllLines(path, TempList.ToArray<string>(),Encoding.ASCII);
            MessageBox.Show(path+"文件保存成功!");
        }

        private void Form1_Load(object sender, EventArgs ee)
        {
            EventHandler handler = (s, e) =>
            {
                if (s == listbox_org)
                    listbox_after.TopIndex = listbox_org.TopIndex;
                if (s == listbox_after)
                    listbox_org.TopIndex = listbox_after.TopIndex;
            };
            this.listbox_org.MouseCaptureChanged += handler;
            this.listbox_after.MouseCaptureChanged += handler;
            this.listbox_org.SelectedIndexChanged += handler;
            this.listbox_after.SelectedIndexChanged += handler;
        }

        private void Listbox_after_MouseCaptureChanged(object sender, EventArgs e)
        {
                listbox_org.TopIndex = listbox_after.TopIndex;
        }

        private void SelMachineType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selMachineType.SelectedIndex == 0)
                txt_progname.Text = "6002";
            else if (selMachineType.SelectedIndex == 1)
                txt_progname.Text = "Axis_Ctrl";
        }
    }
}
