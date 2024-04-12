using Newtonsoft.Json;

namespace Task2;
public partial class Form1 : Form
{
    List<User> users = new List<User>();
    string path = "";
    public Form1()
    {
        InitializeComponent();
        Text = "Anket";
        openFileDialog1.Filter = "Text File|*.json";
        saveFileDialog1.Filter = "Text File|*.json";
    }
    private void Save_Click(object sender, EventArgs e)
    {

        if (search.Text == "")
        {
            MessageBox.Show("Please enter file destination", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        else
            path = search.Text;
        string json = JsonConvert.SerializeObject(users);
        File.WriteAllText(path, json);
    }
    private void SaveChanges_Click(object sender, EventArgs e)
    {
        if (name.Text == "" || surname.Text == "" || phone.Text == "" || email.Text == "")
        {
            MessageBox.Show("Be sure for filling all lines","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            return;
        }
        try
        {
            int index = listBox.SelectedIndex;
            User u = new();
            u.Name = name.Text;
            u.Phone = phone.Text;
            u.Email = email.Text;
            u.Surname = surname.Text;
            u.Birthday = birthday.Value;
            users.RemoveAt(index);
            users.Add(u);
            listBox.DataSource = null;
            listBox.DataSource = users;
        }
        catch
        {
            MessageBox.Show("Something went wrong while openning file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void Load_Click(object sender, EventArgs e)
    {
        if (search.Text == "")
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                try
                {
                    string json = File.ReadAllText(openFileDialog1.FileName);
                    users = JsonConvert.DeserializeObject<List<User>>(json)!;
                    path = openFileDialog1.FileName;
                    listBox.DataSource = users;
                    search.Text = path;
                }
                catch
                {
                    MessageBox.Show("Something went wrong while openning file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        else
            if (File.Exists(search.Text))
        {
            try
            {
                string json = File.ReadAllText(search.Text);
                users = JsonConvert.DeserializeObject<List<User>>(json)!;
                path = search.Text;
                listBox.DataSource = users;
                search.Text = path;
            }
            catch
            {
                MessageBox.Show("Something went wrong while openning file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        else
            MessageBox.Show("File does not exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    private void Add_Click(object sender, EventArgs e)
    {
        User u = new();
        u.Name = name.Text;
        u.Email = email.Text;
        u.Surname = surname.Text;
        u.Phone = phone.Text;
        u.Birthday = birthday.Value;
        users.Add(u);
        listBox.DataSource = null;
        listBox.DataSource = users;
    }
    private void listBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (listBox.SelectedItem != null)
        {
            User? u = listBox.SelectedItem as User;
            name.Text = u.Name;
            email.Text = u.Email;
            surname.Text = u.Surname;
            phone.Text = u.Phone;
            birthday.Value = u.Birthday;
        }
    }
}