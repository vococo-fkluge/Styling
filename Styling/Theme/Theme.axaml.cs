using Avalonia.Markup.Xaml;
using Avalonia.Styling;

namespace Styling.Theme;

public class Theme : Styles {
    public Theme() {
        AvaloniaXamlLoader.Load(this);
    }
}