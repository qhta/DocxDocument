
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a display unit label.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel?view=office-pia"/>
public partial interface IMsoDisplayUnitLabel: IMsoChartTitle
{
  /// <summary>
  /// Gets or sets the `Caption` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.caption?view=office-pia"/>
  public new string Caption { get; set; }
  /// <summary>
  /// Gets the `Characters` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.characters?view=office-pia"/>
  public new IMsoCharacters Characters { get; }
  /// <summary>
  /// Gets the `Font` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.font?view=office-pia"/>
  public new ChartFont Font { get; }
  /// <summary>
  /// Gets or sets the `HorizontalAlignment` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.horizontalalignment?view=office-pia"/>
  public new object HorizontalAlignment { get; set; }
  /// <summary>
  /// Gets or sets the `Left` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.left?view=office-pia"/>
  public new double Left { get; set; }
  /// <summary>
  /// Gets or sets the `Orientation` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.orientation?view=office-pia"/>
  public new object Orientation { get; set; }
  /// <summary>
  /// Gets or sets the `Shadow` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.shadow?view=office-pia"/>
  public new bool Shadow { get; set; }
  /// <summary>
  /// Gets or sets the `Text` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.text?view=office-pia"/>
  public new string Text { get; set; }
  /// <summary>
  /// Gets or sets the `Top` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.top?view=office-pia"/>
  public new double Top { get; set; }
  /// <summary>
  /// Gets or sets the `VerticalAlignment` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.verticalalignment?view=office-pia"/>
  public new object VerticalAlignment { get; set; }
  /// <summary>
  /// Gets or sets the `ReadingOrder` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.readingorder?view=office-pia"/>
  public new int ReadingOrder { get; set; }
  /// <summary>
  /// Gets or sets the `AutoScaleFont` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.autoscalefont?view=office-pia"/>
  public new object AutoScaleFont { get; set; }
  /// <summary>
  /// Gets the `Interior` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.interior?view=office-pia"/>
  public new IMsoInterior Interior { get; }
  /// <summary>
  /// Gets the `Fill` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.fill?view=office-pia"/>
  public new ChartFillFormat Fill { get; }
  /// <summary>
  /// Gets the `Border` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.border?view=office-pia"/>
  public new IMsoBorder Border { get; }
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.name?view=office-pia"/>
  public new string Name { get; }
  /// <summary>
  /// Gets or sets the `IncludeInLayout` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.includeinlayout?view=office-pia"/>
  public new bool IncludeInLayout { get; set; }
  /// <summary>
  /// Gets or sets the `Position` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.position?view=office-pia"/>
  public new ChartElementPosition Position { get; set; }
  /// <summary>
  /// Gets the `Format` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.format?view=office-pia"/>
  public new MsoChartFormat Format { get; }
  /// <summary>
  /// Gets the `Height` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.height?view=office-pia"/>
  public new double Height { get; }
  /// <summary>
  /// Gets the `Width` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.width?view=office-pia"/>
  public new double Width { get; }
  /// <summary>
  /// Gets or sets the `Formula` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.formula?view=office-pia"/>
  public new string Formula { get; set; }
  /// <summary>
  /// Gets or sets the `FormulaR1C1` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.formular1c1?view=office-pia"/>
  public new string FormulaR1C1 { get; set; }
  /// <summary>
  /// Gets or sets the `FormulaLocal` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.formulalocal?view=office-pia"/>
  public new string FormulaLocal { get; set; }
  /// <summary>
  /// Gets or sets the `FormulaR1C1Local` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.formular1c1local?view=office-pia"/>
  public new string FormulaR1C1Local { get; set; }
}

