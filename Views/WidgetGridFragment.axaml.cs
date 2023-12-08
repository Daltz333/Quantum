using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using Avalonia.Styling;
using Quantum.Models;
using Quantum.Widgets;
using System.Collections.Generic;

namespace Quantum.Views;

public partial class WidgetGridFragment : Panel
{
    private ColumnDefinitions ColumnDefinitions { get; set; }
    private RowDefinitions RowDefinitions { get; set; }

    /// <summary>
    /// Cells that define the grid control
    /// </summary>
    public List<Border> Cells { get; private set; } = new List<Border>();

    /// <summary>
    /// Maximum number of cell rows and columns
    /// </summary>
    public readonly int kMaxRowColumns = 27;

    public WidgetGridFragment()
    {
        InitializeComponent();

        ColumnDefinitions = new ColumnDefinitions();
        RowDefinitions = new RowDefinitions();

        int cellWidthHeight = 30;
        var maximumRows = AppProperties.kDefaultHeight / cellWidthHeight;
        var maximumColumns = AppProperties.kDefaultWidth / cellWidthHeight;

        // Generate row/columns
        for (int i = 0; i < kMaxRowColumns; i++)
        {
            // Set all of them to star, to scale with application size
            // We may want to change this behavior later
            ColumnDefinitions.Add(new ColumnDefinition(GridLength.Parse(cellWidthHeight.ToString())));
            RowDefinitions.Add(new RowDefinition(GridLength.Parse(cellWidthHeight.ToString())));
        }

        // Iterate over each row
        for (int i = 0; i < maximumRows; i++)
        {
            // Iterate over each column
            for (int x = 0; x < maximumColumns; x++)
            {
                var cell = new Border();
                cell.Width = cellWidthHeight;
                cell.Height = cellWidthHeight;

                Grid.SetRow(cell, i);
                Grid.SetColumn(cell, x);

                ApplyCellStyle(cell);
                Cells.Add(cell);
            }
        }

        rootGrid.RowDefinitions = RowDefinitions;
        rootGrid.ColumnDefinitions = ColumnDefinitions;
        rootGrid.Children.AddRange(Cells);
    }

    public void ApplyCellStyle(Border cell)
    {
        var theme = Application.Current?.RequestedThemeVariant ?? ThemeVariant.Light;

        if (theme == ThemeVariant.Light)
        {
            cell.BorderBrush = Brush.Parse(Colors.LightGray.ToString());
        } else
        {
            cell.BorderBrush = Brush.Parse(Colors.White.ToString());
        }

        cell.BorderThickness = Thickness.Parse("1");
        cell.Opacity = 0.5;
    }
}