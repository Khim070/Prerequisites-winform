using BookLib;

namespace WinFormBookClient;

public partial class Form1 : Form
{
    private BindingSource bs = new();
    public Form1()
    {
        InitializeComponent();
        bs.DataSource = new List<BookResponse>();
        dgvBooks.DataSource = bs;
        dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        btnRefresh.Click += DoClickRefresh;
        btnDelete.Click += DoClickDelete;
        btnNew.Click += DoClickNew;
        btnEdit.Click += DoClickEdit;
    }

    private void DoClickRefresh(object? sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    private void DoClickEdit(object? sender, EventArgs e)
    {
        var frm = new Form3();
        frm.BookUpdated += DoClickBookUpdated;
        frm.Show();
    }

    private void DoClickBookUpdated(object? sender, string e)
    {
        throw new NotImplementedException();
    }

    private void DoClickNew(object? sender, EventArgs e)
    {
        var frm = new Form2();
        frm.BookCreated += DoBookCreated;
        frm.Show();
    }

    private void DoBookCreated(object? sender, string e)
    {
        throw new NotImplementedException();
    }

    private void DoClickDelete(object? sender, EventArgs e)
    {
        if (bs.Current == null) return;
        var result = MessageBox.Show("Are your sure to delete the current product?",
                                     "Deleting",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question);
        if (result == DialogResult.No) return;
    }
}
