using Avalonia.Controls;
using Avalonia.Input;
namespace Pr8;

public partial class MainWindow : Window
{
    private Voin voin = new Voin();
    private VoinL voinL= new VoinL();
    private VoinT voinT = new VoinT();
    private int damage = 10; 
    public MainWindow()
    {
        InitializeComponent();
        UpdateUI();
    }
        private void Attack(object? sender, PointerPressedEventArgs e)
    {
        voin.mdamage(damage);
        voinL.mdamage(damage);
        voinT.mdamage(damage);
        UpdateUI();
    }
    private void UpdateUI()
    {
        HpVoin.Text = $"Жизненные показатели: {voin.hp}";
        HpVoinL.Text = $"Жизненные показатели: {voinL.hp}";
        HpVoinT.Text = $"Жизненные показатели: {voinT.hp}";
    }
}