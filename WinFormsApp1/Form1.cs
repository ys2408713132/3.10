namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtCM_KeyUp(object sender, KeyEventArgs e)
        {
            double douCM; //����һ��double׃����׃�����Q��douCM

            douCM = Convert.ToDouble(txtCM.Text); //��txtCMݔ�����ֿ�ȡ��ݔ������֣��K���D�Q��double���Y���͑B

            txtM.Text = string.Format("{0:0.##########}", douCM / 100);
            //��douCM�Ĕ�ֵ����100��Ҳ���ǏĹ����D�Q�ɹ���
            //͸�^string.Format��ʽ����С���c�Ṳ10λ�Ĕ��֣��D�ͳ������͑B����txtM�@ʾ�Y��
        }

        private void txtM_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
