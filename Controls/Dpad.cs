namespace Virulence.Controls;
public partial class Dpad : UserControl
{
    public Dpad()
    {
        InitializeComponent();
    }

    public Button BtnUp => btnUp;
    public Button BtnRight => btnRight;
    public Button BtnDown => btnDown;
    public Button BtnLeft => btnLeft;
}
