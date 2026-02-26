using System;
using Avalonia;
using Avalonia.Controls;

namespace Styling.Theme.Logic;

public class Rating : ContentControl {
    protected override Type StyleKeyOverride => typeof(Rating);

    public static readonly StyledProperty<double> CircleSizeProperty = AvaloniaProperty.Register<Rating, double>(
        nameof(CircleSize));
    public double CircleSize {
        get => GetValue(CircleSizeProperty);
        set => SetValue(CircleSizeProperty, value);
    }
}