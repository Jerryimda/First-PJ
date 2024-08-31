using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Jerrybaring1;

public partial class IconButton : Button
{
    public static readonly StyledProperty<string> PathDataProperty =
        AvaloniaProperty.Register<IconButton, string>(nameof(PathData));


    public string PathData
    {
        get => this.GetValue(PathDataProperty);
        set => SetValue(PathDataProperty, value);
    }
    public IconButton()
    {
        InitializeComponent();
    }
}