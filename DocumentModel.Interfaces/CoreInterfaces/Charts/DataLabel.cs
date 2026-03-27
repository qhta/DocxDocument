
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Represents a data label.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel?view=office-pia"/>
public partial interface DataLabel: InteropObject
{
  /// <summary>
  /// Gets or sets the `Name` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.name?view=office-pia"/>
  public string Name { get; }
  /// <summary>
  /// Gets the `Border` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.border?view=office-pia"/>
  public Border Border { get; }
  /// <summary>
  /// Gets the `Interior` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.interior?view=office-pia"/>
  public Interior Interior { get; }
  /// <summary>
  /// Gets the `Fill` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.fill?view=office-pia"/>
  public ChartFillFormat Fill { get; }
  /// <summary>
  /// Gets or sets the `Caption` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.caption?view=office-pia"/>
  public string Caption { get; set; }
  /// <summary>
  /// Gets the `Characters` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.characters?view=office-pia"/>
  public Characters Characters { get; }
  /// <summary>
  /// Gets the `Font` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.font?view=office-pia"/>
  public ChartFont Font { get; }
  /// <summary>
  /// Gets or sets the `HorizontalAlignment` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.horizontalalignment?view=office-pia"/>
  public object HorizontalAlignment { get; set; }
  /// <summary>
  /// Gets or sets the `Left` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.left?view=office-pia"/>
  public double Left { get; set; }
  /// <summary>
  /// Gets or sets the `Orientation` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.orientation?view=office-pia"/>
  public object Orientation { get; set; }
  /// <summary>
  /// Gets or sets the `Shadow` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.shadow?view=office-pia"/>
  public bool Shadow { get; set; }
  /// <summary>
  /// Gets or sets the `Text` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.text?view=office-pia"/>
  public string Text { get; set; }
  /// <summary>
  /// Gets or sets the `Top` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.top?view=office-pia"/>
  public double Top { get; set; }
  /// <summary>
  /// Gets or sets the `VerticalAlignment` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.verticalalignment?view=office-pia"/>
  public object VerticalAlignment { get; set; }
  /// <summary>
  /// Gets or sets the `ReadingOrder` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.readingorder?view=office-pia"/>
  public int ReadingOrder { get; set; }
  /// <summary>
  /// Gets or sets the `AutoScaleFont` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.autoscalefont?view=office-pia"/>
  public object AutoScaleFont { get; set; }
  /// <summary>
  /// Gets or sets the `AutoText` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.autotext?view=office-pia"/>
  public bool AutoText { get; set; }
  /// <summary>
  /// Gets or sets the `NumberFormat` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.numberformat?view=office-pia"/>
  public string NumberFormat { get; set; }
  /// <summary>
  /// Gets or sets the `NumberFormatLinked` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.numberformatlinked?view=office-pia"/>
  public bool NumberFormatLinked { get; set; }
  /// <summary>
  /// Gets or sets the `NumberFormatLocal` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.numberformatlocal?view=office-pia"/>
  public object NumberFormatLocal { get; set; }
  /// <summary>
  /// Gets or sets the `ShowLegendKey` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.showlegendkey?view=office-pia"/>
  public bool ShowLegendKey { get; set; }
  /// <summary>
  /// Gets or sets the `Type` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.type?view=office-pia"/>
  public object Type { get; set; }
  /// <summary>
  /// Gets or sets the `Position` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.position?view=office-pia"/>
  public DataLabelPosition Position { get; set; }
  /// <summary>
  /// Gets or sets the `ShowSeriesName` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.showseriesname?view=office-pia"/>
  public bool ShowSeriesName { get; set; }
  /// <summary>
  /// Gets or sets the `ShowCategoryName` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.showcategoryname?view=office-pia"/>
  public bool ShowCategoryName { get; set; }
  /// <summary>
  /// Gets or sets the `ShowValue` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.showvalue?view=office-pia"/>
  public bool ShowValue { get; set; }
  /// <summary>
  /// Gets or sets the `ShowPercentage` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.showpercentage?view=office-pia"/>
  public bool ShowPercentage { get; set; }
  /// <summary>
  /// Gets or sets the `ShowBubbleSize` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.showbubblesize?view=office-pia"/>
  public bool ShowBubbleSize { get; set; }
  /// <summary>
  /// Gets or sets the `Separator` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.separator?view=office-pia"/>
  public object Separator { get; set; }
  /// <summary>
  /// Gets the `Format` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.format?view=office-pia"/>
  public ChartFormat Format { get; }
  /// <summary>
  /// Gets the `_Height` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel._height?view=office-pia"/>
  public double _Height { get; }
  /// <summary>
  /// Gets the `_Width` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel._width?view=office-pia"/>
  public double _Width { get; }
  /// <summary>
  /// Gets or sets the `Formula` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.formula?view=office-pia"/>
  public string Formula { get; set; }
  /// <summary>
  /// Gets or sets the `FormulaR1C1` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.formular1c1?view=office-pia"/>
  public string FormulaR1C1 { get; set; }
  /// <summary>
  /// Gets or sets the `FormulaLocal` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.formulalocal?view=office-pia"/>
  public string FormulaLocal { get; set; }
  /// <summary>
  /// Gets or sets the `FormulaR1C1Local` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.formular1c1local?view=office-pia"/>
  public string FormulaR1C1Local { get; set; }
  /// <summary>
  /// Gets or sets the `ShowRange` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.showrange?view=office-pia"/>
  public bool ShowRange { get; set; }
  /// <summary>
  /// Gets or sets the `Height` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.height?view=office-pia"/>
  public double Height { get; set; }
  /// <summary>
  /// Gets or sets the `Width` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.width?view=office-pia"/>
  public double Width { get; set; }
}

