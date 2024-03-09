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
using Tcl;

namespace ShowCase;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
  private readonly Button btnTest;
  private readonly Tcl.TaskManager tmTaskManager;

  public MainWindow()
  {
    InitializeComponent();
    this.btnTest = BtnTest;
    this.tmTaskManager = new Tcl.TaskManager();
  }

  private void vidBtnTestClick(
    object objSender,
    RoutedEventArgs reaEvent
  )
  {
    this.btnTest.Content = this.tmTaskManager.strTest();
    MessageBox.Show("Button is clicked..");
  }
}