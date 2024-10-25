using BookLib;

namespace WinFormBookClient;

public partial class Form3 : Form
{
    private BookResponse? curBook = null;
    public event EventHandler<string>? BookUpdated=null;
    public Form3(BookResponse? book=null)
    {
        InitializeComponent();
        curBook = book;

        txtTitle.DataBindings.Add("ReadOnly", chkTitle, "Checked").Format += (sender, e) =>
        {
            e.Value = !((bool)e.Value!);
        };
        txtPages.DataBindings.Add("ReadOnly", chkPages, "Checked").Format += (sender, e) =>
        {
            e.Value = !((bool)e.Value!);
        };
        ShowCurrentBook();

        btnCancel.Click += (sender, e) => { ShowCurrentBook(); };
        btnSubmit.Click += DoClickSubmit;
    }

    private void DoClickSubmit(object? sender, EventArgs e)
    {
        BookUpdated?.Invoke(this, "UpdatedBook's id");
    }

    private void ShowCurrentBook()
    {
        txtId.Text = curBook?.Id;
        txtTitle.Text = curBook?.Title;
        txtPages.Text = curBook?.Pages.ToString();
    }
}

   

