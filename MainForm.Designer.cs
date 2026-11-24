namespace XmlJsonAdapterApp;

partial class MainForm
{
    private System.ComponentModel.IContainer? components = null;
    private GroupBox grpDirection = null!;
    private RadioButton rbXmlToJson = null!;
    private RadioButton rbJsonToXml = null!;
    private Label lblInput = null!;
    private Label lblOutput = null!;
    private TextBox txtInput = null!;
    private TextBox txtOutput = null!;
    private Button btnConvert = null!;
    private Button btnExample = null!;
    private Button btnCopy = null!;
    private Button btnClear = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        grpDirection = new GroupBox();
        rbJsonToXml = new RadioButton();
        rbXmlToJson = new RadioButton();
        lblInput = new Label();
        lblOutput = new Label();
        txtInput = new TextBox();
        txtOutput = new TextBox();
        btnConvert = new Button();
        btnExample = new Button();
        btnCopy = new Button();
        btnClear = new Button();
        grpDirection.SuspendLayout();
        SuspendLayout();
        // 
        // grpDirection
        // 
        grpDirection.Controls.Add(rbJsonToXml);
        grpDirection.Controls.Add(rbXmlToJson);
        grpDirection.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        grpDirection.Location = new Point(22, 12);
        grpDirection.Name = "grpDirection";
        grpDirection.Size = new Size(940, 66);
        grpDirection.TabIndex = 0;
        grpDirection.TabStop = false;
        grpDirection.Text = "Напрямок перетворення";
        // 
        // rbJsonToXml
        // 
        rbJsonToXml.AutoSize = true;
        rbJsonToXml.Font = new Font("Segoe UI", 9F);
        rbJsonToXml.Location = new Point(170, 27);
        rbJsonToXml.Name = "rbJsonToXml";
        rbJsonToXml.Size = new Size(93, 19);
        rbJsonToXml.TabIndex = 1;
        rbJsonToXml.Text = "JSON → XML";
        rbJsonToXml.CheckedChanged += rbDirection_CheckedChanged;
        // 
        // rbXmlToJson
        // 
        rbXmlToJson.AutoSize = true;
        rbXmlToJson.Checked = true;
        rbXmlToJson.Font = new Font("Segoe UI", 9F);
        rbXmlToJson.Location = new Point(22, 27);
        rbXmlToJson.Name = "rbXmlToJson";
        rbXmlToJson.Size = new Size(93, 19);
        rbXmlToJson.TabIndex = 0;
        rbXmlToJson.TabStop = true;
        rbXmlToJson.Text = "XML → JSON";
        rbXmlToJson.CheckedChanged += rbDirection_CheckedChanged;
        // 
        // lblInput
        // 
        lblInput.AutoSize = true;
        lblInput.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblInput.Location = new Point(22, 90);
        lblInput.Name = "lblInput";
        lblInput.Size = new Size(129, 19);
        lblInput.TabIndex = 10;
        lblInput.Text = "Вхідні дані (XML)";
        // 
        // lblOutput
        // 
        lblOutput.AutoSize = true;
        lblOutput.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblOutput.Location = new Point(500, 90);
        lblOutput.Name = "lblOutput";
        lblOutput.Size = new Size(126, 19);
        lblOutput.TabIndex = 9;
        lblOutput.Text = "Результат (JSON)";
        // 
        // txtInput
        // 
        txtInput.AcceptsTab = true;
        txtInput.Font = new Font("Consolas", 10F);
        txtInput.Location = new Point(22, 117);
        txtInput.Multiline = true;
        txtInput.Name = "txtInput";
        txtInput.ScrollBars = ScrollBars.Both;
        txtInput.Size = new Size(455, 350);
        txtInput.TabIndex = 2;
        txtInput.WordWrap = false;
        // 
        // txtOutput
        // 
        txtOutput.AcceptsTab = true;
        txtOutput.Font = new Font("Consolas", 10F);
        txtOutput.Location = new Point(500, 117);
        txtOutput.Multiline = true;
        txtOutput.Name = "txtOutput";
        txtOutput.ReadOnly = true;
        txtOutput.ScrollBars = ScrollBars.Both;
        txtOutput.Size = new Size(462, 350);
        txtOutput.TabIndex = 3;
        txtOutput.WordWrap = false;
        // 
        // btnConvert
        // 
        btnConvert.BackColor = Color.White;
        btnConvert.FlatStyle = FlatStyle.Flat;
        btnConvert.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        btnConvert.ForeColor = Color.Black;
        btnConvert.Location = new Point(22, 525);
        btnConvert.Name = "btnConvert";
        btnConvert.Size = new Size(190, 42);
        btnConvert.TabIndex = 4;
        btnConvert.Text = "Перетворити";
        btnConvert.UseVisualStyleBackColor = false;
        btnConvert.Click += btnConvert_Click;
        // 
        // btnExample
        // 
        btnExample.BackColor = Color.White;
        btnExample.FlatStyle = FlatStyle.Flat;
        btnExample.Font = new Font("Segoe UI", 9F);
        btnExample.ForeColor = Color.Black;
        btnExample.Location = new Point(225, 525);
        btnExample.Name = "btnExample";
        btnExample.Size = new Size(150, 42);
        btnExample.TabIndex = 5;
        btnExample.Text = "Завантажити приклад";
        btnExample.UseVisualStyleBackColor = false;
        btnExample.Click += btnExample_Click;
        // 
        // btnCopy
        // 
        btnCopy.BackColor = Color.White;
        btnCopy.FlatStyle = FlatStyle.Flat;
        btnCopy.Font = new Font("Segoe UI", 9F);
        btnCopy.ForeColor = Color.Black;
        btnCopy.Location = new Point(500, 525);
        btnCopy.Name = "btnCopy";
        btnCopy.Size = new Size(150, 42);
        btnCopy.TabIndex = 6;
        btnCopy.Text = "Копіювати результат";
        btnCopy.UseVisualStyleBackColor = false;
        btnCopy.Click += btnCopy_Click;
        // 
        // btnClear
        // 
        btnClear.BackColor = Color.White;
        btnClear.FlatStyle = FlatStyle.Flat;
        btnClear.Font = new Font("Segoe UI", 9F);
        btnClear.ForeColor = Color.Black;
        btnClear.Location = new Point(662, 525);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(130, 42);
        btnClear.TabIndex = 7;
        btnClear.Text = "Очистити";
        btnClear.UseVisualStyleBackColor = false;
        btnClear.Click += btnClear_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 248, 252);
        ClientSize = new Size(984, 661);
        Controls.Add(btnClear);
        Controls.Add(btnCopy);
        Controls.Add(btnExample);
        Controls.Add(btnConvert);
        Controls.Add(txtOutput);
        Controls.Add(txtInput);
        Controls.Add(lblOutput);
        Controls.Add(lblInput);
        Controls.Add(grpDirection);
        MinimumSize = new Size(1000, 700);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Адаптер XML та JSON";
        grpDirection.ResumeLayout(false);
        grpDirection.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }
}
