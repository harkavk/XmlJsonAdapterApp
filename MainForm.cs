namespace XmlJsonAdapterApp;

public partial class MainForm : Form
{
    private readonly IDataAdapter adapter = new XmlJsonAdapter();

    public MainForm()
    {
        InitializeComponent();
        LoadExample();
    }

    private void btnConvert_Click(object? sender, EventArgs e)
    {
        string source = txtInput.Text.Trim();
        if (string.IsNullOrWhiteSpace(source))
        {
            MessageBox.Show("Введіть дані для перетворення.", "Увага",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            txtOutput.Text = rbXmlToJson.Checked
                ? adapter.XmlToJson(source)
                : adapter.JsonToXml(source);
            SetStatus("Перетворення виконано успішно.");
        }
        catch (Exception ex)
        {
            txtOutput.Clear();
            SetStatus("Помилка перетворення.");
            MessageBox.Show("Не вдалося виконати перетворення:\n" + ex.Message,
                "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnExample_Click(object? sender, EventArgs e)
    {
        LoadExample();
        SetStatus("Приклад завантажено.");
    }

    private void btnCopy_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtOutput.Text))
        {
            MessageBox.Show("Немає результату для копіювання.", "Увага",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        Clipboard.SetText(txtOutput.Text);
        SetStatus("Результат скопійовано до буфера обміну.");
    }

    private void btnClear_Click(object? sender, EventArgs e)
    {
        txtInput.Clear();
        txtOutput.Clear();
        SetStatus("Поля очищено.");
    }

    private void rbDirection_CheckedChanged(object? sender, EventArgs e)
    {
        if (rbXmlToJson.Checked)
        {
            lblInput.Text = "Вхідні дані (XML)";
            lblOutput.Text = "Результат (JSON)";
        }
        else
        {
            lblInput.Text = "Вхідні дані (JSON)";
            lblOutput.Text = "Результат (XML)";
        }
        txtOutput.Clear();
    }

    private void LoadExample()
    {
        if (rbXmlToJson.Checked)
        {
            txtInput.Text = "<person>\r\n  <name>Іван</name>\r\n  <age>20</age>\r\n  <city>Київ</city>\r\n</person>";
        }
        else
        {
            txtInput.Text = "{\r\n  \"person\": {\r\n    \"name\": \"Іван\",\r\n    \"age\": 20,\r\n    \"city\": \"Київ\"\r\n  }\r\n}";
        }
        txtOutput.Clear();
    }

    private void SetStatus(string message)
    {
       
    }
}
