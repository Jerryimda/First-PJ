using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Jerrybaring1;

public partial class LineButton : Button
{
    public static readonly StyledProperty<string> LineTextProperty =
        AvaloniaProperty.Register<LineButton, string>(nameof(LineText));

    public string LineText
    {
        get => this.GetValue(LineTextProperty);
        set => SetValue(LineTextProperty, value);
    }

    public static readonly StyledProperty<string> NameTextProperty =
        AvaloniaProperty.Register<LineButton, string>(nameof(NameText));

    public string NameText
    {
        get => this.GetValue(NameTextProperty);
        set => SetValue(NameTextProperty, value);
    }

    public static readonly StyledProperty<string> JobTextProperty =
        AvaloniaProperty.Register<LineButton, string>(nameof(JobText));

    public string JobText
    {
        get => this.GetValue(JobTextProperty);
        set => SetValue(JobTextProperty, value);
    }
    public LineButton()
    {
        InitializeComponent();
    }
}