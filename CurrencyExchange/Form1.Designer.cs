namespace CurrencyExchange
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ConvertFrom_combobox = new ComboBox();
            ConvertTo_combobox = new ComboBox();
            Amount_textbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Converted_label = new Label();
            button1 = new Button();
            ConversionRate_label = new Label();
            SuspendLayout();
            // 
            // ConvertFrom_combobox
            // 
            ConvertFrom_combobox.FormattingEnabled = true;
            ConvertFrom_combobox.Items.AddRange(new object[] { "AUD - Австралійський долар", "CAD - Канадський долар", "CNY - Юань Женьміньбі", "CZK - Чеська крона", "DKK - Данська крона", "HKD - Гонконгівський долар", "HUF - Форинт", "INR - Індійська рупія", "IDR - Рупія", "ILS - Новий ізраїльський шекель", "JPY - Єна", "KZT - Теньге", "KRW - Вона", "MXN - Мексиканське песо", "MDL - Молдовський лей", "NZD - Новозеландський долар", "NOK - Норвезька крона", "RUB - Російський рубль", "SGD - Сінгапурський долар", "ZAR - Ренд", "SEK - Шведська крона", "CHF - Швейцарський франк", "EGP - Єгипетський фунт", "GBP - Фунт стерлінгів", "USD - Долар США", "BYN - Білоруський рубль", "AZN - Азербайджанський манат", "RON - Румунський лей", "TRY - Турецька ліра", "XDR - СПЗ (спеціальні права запозичення)", "BGN - Болгарський лев", "EUR - Євро", "PLN - Злотий", "DZD - Алжирський динар", "BDT - Така", "AMD - Вірменський драм", "DOP - Домініканське песо", "IRR - Іранський ріал", "IQD - Іракський динар", "KGS - Сом", "LBP - Ліванський фунт", "LYD - Лівійський динар", "MYR - Малайзійський ринггіт", "MAD - Марокканський дирхам", "PKR - Пакистанська рупія", "SAR - Саудівський ріял", "VND - Донг", "THB - Бат", "AED - Дирхам ОАЕ", "TND - Туніський динар", "UZS - Узбецький сум", "TWD - Новий тайванський долар", "TMT - Туркменський новий манат", "RSD - Сербський динар", "TJS - Сомоні", "GEL - Ларі", "BRL - Бразильський реал", "UAH - Українська гривня", "XAU - Золото", "XAG - Срібло", "XPT - Платина", "XPD - Паладій" });
            ConvertFrom_combobox.Location = new Point(151, 83);
            ConvertFrom_combobox.Name = "ConvertFrom_combobox";
            ConvertFrom_combobox.Size = new Size(285, 23);
            ConvertFrom_combobox.TabIndex = 1;
            // 
            // ConvertTo_combobox
            // 
            ConvertTo_combobox.FormattingEnabled = true;
            ConvertTo_combobox.Items.AddRange(new object[] { "AUD - Австралійський долар", "CAD - Канадський долар", "CNY - Юань Женьміньбі", "CZK - Чеська крона", "DKK - Данська крона", "HKD - Гонконгівський долар", "HUF - Форинт", "INR - Індійська рупія", "IDR - Рупія", "ILS - Новий ізраїльський шекель", "JPY - Єна", "KZT - Теньге", "KRW - Вона", "MXN - Мексиканське песо", "MDL - Молдовський лей", "NZD - Новозеландський долар", "NOK - Норвезька крона", "RUB - Російський рубль", "SGD - Сінгапурський долар", "ZAR - Ренд", "SEK - Шведська крона", "CHF - Швейцарський франк", "EGP - Єгипетський фунт", "GBP - Фунт стерлінгів", "USD - Долар США", "BYN - Білоруський рубль", "AZN - Азербайджанський манат", "RON - Румунський лей", "TRY - Турецька ліра", "XDR - СПЗ (спеціальні права запозичення)", "BGN - Болгарський лев", "EUR - Євро", "PLN - Злотий", "DZD - Алжирський динар", "BDT - Така", "AMD - Вірменський драм", "DOP - Домініканське песо", "IRR - Іранський ріал", "IQD - Іракський динар", "KGS - Сом", "LBP - Ліванський фунт", "LYD - Лівійський динар", "MYR - Малайзійський ринггіт", "MAD - Марокканський дирхам", "PKR - Пакистанська рупія", "SAR - Саудівський ріял", "VND - Донг", "THB - Бат", "AED - Дирхам ОАЕ", "TND - Туніський динар", "UZS - Узбецький сум", "TWD - Новий тайванський долар", "TMT - Туркменський новий манат", "RSD - Сербський динар", "TJS - Сомоні", "GEL - Ларі", "BRL - Бразильський реал", "UAH - Українська гривня", "XAU - Золото", "XAG - Срібло", "XPT - Платина", "XPD - Паладій" });
            ConvertTo_combobox.Location = new Point(151, 125);
            ConvertTo_combobox.Name = "ConvertTo_combobox";
            ConvertTo_combobox.Size = new Size(285, 23);
            ConvertTo_combobox.TabIndex = 2;
            // 
            // Amount_textbox
            // 
            Amount_textbox.Location = new Point(151, 39);
            Amount_textbox.Name = "Amount_textbox";
            Amount_textbox.Size = new Size(285, 23);
            Amount_textbox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(45, 37);
            label1.Name = "label1";
            label1.Size = new Size(76, 21);
            label1.TabIndex = 4;
            label1.Text = "Amount:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(45, 81);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 5;
            label2.Text = "From:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(45, 127);
            label3.Name = "label3";
            label3.Size = new Size(33, 21);
            label3.TabIndex = 6;
            label3.Text = "To:";
            // 
            // Converted_label
            // 
            Converted_label.AutoSize = true;
            Converted_label.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Converted_label.Location = new Point(45, 221);
            Converted_label.Name = "Converted_label";
            Converted_label.Size = new Size(189, 21);
            Converted_label.TabIndex = 7;
            Converted_label.Text = "Converted amount: ???";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkRed;
            button1.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Snow;
            button1.Location = new Point(337, 259);
            button1.Name = "button1";
            button1.Size = new Size(99, 32);
            button1.TabIndex = 9;
            button1.Text = "Convert";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ConversionRate_label
            // 
            ConversionRate_label.AutoSize = true;
            ConversionRate_label.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ConversionRate_label.Location = new Point(45, 189);
            ConversionRate_label.Name = "ConversionRate_label";
            ConversionRate_label.Size = new Size(216, 21);
            ConversionRate_label.TabIndex = 10;
            ConversionRate_label.Text = "Convertsion rate: 1$ = ???";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(448, 303);
            Controls.Add(ConversionRate_label);
            Controls.Add(button1);
            Controls.Add(Converted_label);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Amount_textbox);
            Controls.Add(ConvertTo_combobox);
            Controls.Add(ConvertFrom_combobox);
            Name = "Form1";
            Text = "Обмін валют";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox ConvertTo_combobox;
        private TextBox Amount_textbox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label Converted_label;
        private Button button1;
        private ComboBox ConvertFrom_combobox;
        private Label ConversionRate_label;
    }
}