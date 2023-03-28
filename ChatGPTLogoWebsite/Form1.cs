using System.Windows.Forms;

namespace ChatGPTLogoWebsite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Logo_Click(object sender, EventArgs e)
        {

        }



        private async void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var api = new OpenAI_API.OpenAIAPI("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");
            var chat = api.Chat.CreateConversation();
            chat.AppendUserInput(userInput.Text);


            string response = await chat.GetResponseFromChatbot();
            label1.Text = response; 
        }
    }
}