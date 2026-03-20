
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a display unit label.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel?view=office-pia
/// </remarks>
public partial interface IMsoDisplayUnitLabel: IMsoChartTitle
{
  /// <summary>
  /// Gets or sets the `Caption` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.caption?view=office-pia
  /// </remarks>
  public new string Caption { get; set; }
  /// <summary>
  /// Gets the `Characters` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.characters?view=office-pia
  /// </remarks>
  public new IMsoCharacters Characters { get; }
  /// <summary>
  /// Gets the `Font` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.font?view=office-pia
  /// </remarks>
  public new ChartFont Font { get; }
  /// <summary>
  /// Gets or sets the `HorizontalAlignment` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.horizontalalignment?view=office-pia
  /// </remarks>
  public new object HorizontalAlignment { get; set; }
  /// <summary>
  /// Gets or sets the `Left` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.left?view=office-pia
  /// </remarks>
  public new double Left { get; set; }
  /// <summary>
  /// Gets or sets the `Orientation` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.orientation?view=office-pia
  /// </remarks>
  public new object Orientation { get; set; }
  /// <summary>
  /// Gets or sets the `Shadow` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.shadow?view=office-pia
  /// </remarks>
  public new bool Shadow { get; set; }
  /// <summary>
  /// Gets or sets the `Text` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.text?view=office-pia
  /// </remarks>
  public new string Text { get; set; }
  /// <summary>
  /// Gets or sets the `Top` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.top?view=office-pia
  /// </remarks>
  public new double Top { get; set; }
  /// <summary>
  /// Gets or sets the `VerticalAlignment` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.verticalalignment?view=office-pia
  /// </remarks>
  public new object VerticalAlignment { get; set; }
  /// <summary>
  /// Gets or sets the `ReadingOrder` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.readingorder?view=office-pia
  /// </remarks>
  public new int ReadingOrder { get; set; }
  /// <summary>
  /// Gets or sets the `AutoScaleFont` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.autoscalefont?view=office-pia
  /// </remarks>
  public new object AutoScaleFont { get; set; }
  /// <summary>
  /// Gets the `Interior` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.interior?view=office-pia
  /// </remarks>
  public new IMsoInterior Interior { get; }
  /// <summary>
  /// Gets the `Fill` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.fill?view=office-pia
  /// </remarks>
  public new ChartFillFormat Fill { get; }
  /// <summary>
  /// Gets the `Border` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.border?view=office-pia
  /// </remarks>
  public new IMsoBorder Border { get; }
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.name?view=office-pia
  /// </remarks>
  public new string Name { get; }
  /// <summary>
  /// Gets or sets the `IncludeInLayout` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.includeinlayout?view=office-pia
  /// </remarks>
  public new bool IncludeInLayout { get; set; }
  /// <summary>
  /// Gets or sets the `Position` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.position?view=office-pia
  /// </remarks>
  public new XlChartElementPosition Position { get; set; }
  /// <summary>
  /// Gets the `Format` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.format?view=office-pia
  /// </remarks>
  public new IMsoChartFormat Format { get; }
  /// <summary>
  /// Gets the `Height` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.height?view=office-pia
  /// </remarks>
  public new double Height { get; }
  /// <summary>
  /// Gets the `Width` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.width?view=office-pia
  /// </remarks>
  public new double Width { get; }
  /// <summary>
  /// Gets or sets the `Formula` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.formula?view=office-pia
  /// </remarks>
  public new string Formula { get; set; }
  /// <summary>
  /// Gets or sets the `FormulaR1C1` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.formular1c1?view=office-pia
  /// </remarks>
  public new string FormulaR1C1 { get; set; }
  /// <summary>
  /// Gets or sets the `FormulaLocal` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.formulalocal?view=office-pia
  /// </remarks>
  public new string FormulaLocal { get; set; }
  /// <summary>
  /// Gets or sets the `FormulaR1C1Local` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.formular1c1local?view=office-pia
  /// </remarks>
  public new string FormulaR1C1Local { get; set; }
}
