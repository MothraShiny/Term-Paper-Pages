namespace Term_Paper_Pages.View
{
    public partial class PageView : Form
    {
        //Поля
        private string _message;
        private bool _isSuccessful;
        private bool _isEdit;

        //Конструктор
        public PageView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPagePetDetail);
            btnClose.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            //Поиск
            buttonSearchLettersCountMoreThan.Click += delegate { SearchLettersCountMoreThanEvent?.Invoke(this, EventArgs.Empty); };
            //Сброс поиска
            buttonResetSearch.Click += delegate { ResetSearchEvent?.Invoke(this, EventArgs.Empty); };

            //Добавление
            btnAddNew.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPagePetList);
                tabControl1.TabPages.Add(tabPagePetDetail);
                tabPagePetDetail.Text = "Добавить новую";
            };
            //Изменение
            btnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPagePetList);
                tabControl1.TabPages.Add(tabPagePetDetail);
                tabPagePetDetail.Text = "Изменить существующую";
            };
            //Сохранение изменений
            btnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (_isSuccessful)
                {
                    tabControl1.TabPages.Remove(tabPagePetDetail);
                    tabControl1.TabPages.Add(tabPagePetList);
                }
                MessageBox.Show(Message);
            };
            //Отмена
            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPagePetDetail);
                tabControl1.TabPages.Add(tabPagePetList);
            };
            //Удаление
            btnDelete.Click += delegate
            {
                var result = MessageBox.Show("Вы действительно хотите удалить выбранную Страницу?", "Внимание",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
        }

        //Свойства
        public int PageId
        {
            get { return Int32.Parse(txtPageId.Text); }
            set { txtPageId.Text = value.ToString(); }
        }

        public int PageNumberOfLetters
        {
            get { return Convert.ToInt32(numericUpDownNumberOfLetters.Value); }
            set { numericUpDownNumberOfLetters.Value = value; }
        }

        public int PageNumberOfVowels
        {
            get { return Convert.ToInt32(numericUpDownNumberOfVowels.Value); }
            set { numericUpDownNumberOfVowels.Value = value; }
        }

        public int PageNumberOfСonsonants
        {
            get { return Convert.ToInt32(numericUpDownNumberOfСonsonants.Value); }
            set { numericUpDownNumberOfСonsonants.Value = value; }
        }

        public int PageFontSize
        {
            get { return Convert.ToInt32(numericUpDownFontSize.Value); }
            set { numericUpDownFontSize.Value = value; }
        }

        public int PageNumberOfParagraphs
        {
            get { return Convert.ToInt32(numericUpDownNumberOfParagraphs.Value); }
            set { numericUpDownNumberOfParagraphs.Value = value; }
        }

        public int PageNumber
        {
            get { return Convert.ToInt32(numericUpDownPageNumber.Value); }
            set { numericUpDownPageNumber.Value = value; }
        }

        public int PageNumberOfLines
        {
            get { return Convert.ToInt32(numericUpDownNumberOfLines.Value); }
            set { numericUpDownNumberOfLines.Value = value; }
        }

        public double AverageLettersCount
        {
            get { return Convert.ToDouble(labelAverageLettersCount.Text); }
            set { labelAverageLettersCount.Text = value.ToString(); }
        }

        public int ValueLettersCountMoreThan
        {
            get { return Convert.ToInt32(numericUpDownLettersCountMoreThan.Value); }
        }

        public bool IsEdit
        {
            get { return _isEdit; }
            set { _isEdit = value; }
        }

        public bool IsSuccessful
        {
            get { return _isSuccessful; }
            set { _isSuccessful = value; }
        }

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        //События
        public event EventHandler SearchLettersCountMoreThanEvent;
        public event EventHandler ResetSearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        //Методы
        public void SetPageListBindingSource(BindingSource pageList)
        {
            dataGridView.DataSource = pageList;
        }

        //Синглтон паттерн (для открытия формы по одной ссылке)
        private static PageView _instance;
        public static PageView GetInstace(Form parentContainer)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new PageView();
                _instance.MdiParent = parentContainer;
                _instance.FormBorderStyle = FormBorderStyle.None;
                _instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (_instance.WindowState == FormWindowState.Minimized)
                    _instance.WindowState = FormWindowState.Normal;
                _instance.BringToFront();
            }
            return _instance;
        }
    }
}
