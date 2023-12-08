using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using Avalonia.Styling;
using Quantum.Models;
using Quantum.Widgets;
using System;
using System.Collections.Generic;

namespace Quantum.Views;

public partial class WidgetGridFragment : Panel
{
    public WidgetGridFragment()
    {
        InitializeComponent();
    }


    protected override void OnMeasureInvalidated()
    {
        base.OnMeasureInvalidated();
    }
}