using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Student_Information_Entry;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }

    private void OpenEntryPage_Click(object sender, RoutedEventArgs e)
    {
        EntryPage entryPage = new EntryPage();
        entryPage.Show();
        this.Close();
    }

    private void OpenDevelopersPage_Click(object sender, RoutedEventArgs e)
    {
        DevelopersPage developersPage = new DevelopersPage();
        developersPage.Show();
        this.Close();
    }
}

internal class DevelopersPage
{
    public DevelopersPage()
    {
    }

    internal void Show()
    {
        throw new NotImplementedException();
    }
}

internal class EntryPage
{
    public EntryPage()
    {
    }

    internal void Show()
    {
        throw new NotImplementedException();
    }
}