
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a data label.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel?view=office-pia
/// </remarks>
public partial interface IMsoDataLabel
{
  /// <summary>
  /// Gets or sets the `Name` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.name?view=office-pia
  /// </remarks>
  public string Name { get; }
  /// <summary>
  /// Gets the `Border` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.border?view=office-pia
  /// </remarks>
  public IMsoBorder Border { get; }
  /// <summary>
  /// Gets the `Interior` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.interior?view=office-pia
  /// </remarks>
  public IMsoInterior Interior { get; }
  /// <summary>
  /// Gets the `Fill` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.fill?view=office-pia
  /// </remarks>
  public ChartFillFormat Fill { get; }
  /// <summary>
  /// Gets or sets the `Caption` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.caption?view=office-pia
  /// </remarks>
  public string Caption { get; set; }
  /// <summary>
  /// Gets the `Characters` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.characters?view=office-pia
  /// </remarks>
  public IMsoCharacters Characters { get; }
  /// <summary>
  /// Gets the `Font` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.font?view=office-pia
  /// </remarks>
  public ChartFont Font { get; }
  /// <summary>
  /// Gets or sets the `HorizontalAlignment` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.horizontalalignment?view=office-pia
  /// </remarks>
  public object HorizontalAlignment { get; set; }
  /// <summary>
  /// Gets or sets the `Left` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.left?view=office-pia
  /// </remarks>
  public double Left { get; set; }
  /// <summary>
  /// Gets or sets the `Orientation` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.orientation?view=office-pia
  /// </remarks>
  public object Orientation { get; set; }
  /// <summary>
  /// Gets or sets the `Shadow` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.shadow?view=office-pia
  /// </remarks>
  public bool Shadow { get; set; }
  /// <summary>
  /// Gets or sets the `Text` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.text?view=office-pia
  /// </remarks>
  public string Text { get; set; }
  /// <summary>
  /// Gets or sets the `Top` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.top?view=office-pia
  /// </remarks>
  public double Top { get; set; }
  /// <summary>
  /// Gets or sets the `VerticalAlignment` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.verticalalignment?view=office-pia
  /// </remarks>
  public object VerticalAlignment { get; set; }
  /// <summary>
  /// Gets or sets the `ReadingOrder` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.readingorder?view=office-pia
  /// </remarks>
  public int ReadingOrder { get; set; }
  /// <summary>
  /// Gets or sets the `AutoScaleFont` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.autoscalefont?view=office-pia
  /// </remarks>
  public object AutoScaleFont { get; set; }
  /// <summary>
  /// Gets or sets the `AutoText` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.autotext?view=office-pia
  /// </remarks>
  public bool AutoText { get; set; }
  /// <summary>
  /// Gets or sets the `NumberFormat` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.numberformat?view=office-pia
  /// </remarks>
  public string NumberFormat { get; set; }
  /// <summary>
  /// Gets or sets the `NumberFormatLinked` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.numberformatlinked?view=office-pia
  /// </remarks>
  public bool NumberFormatLinked { get; set; }
  /// <summary>
  /// Gets or sets the `NumberFormatLocal` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.numberformatlocal?view=office-pia
  /// </remarks>
  public object NumberFormatLocal { get; set; }
  /// <summary>
  /// Gets or sets the `ShowLegendKey` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.showlegendkey?view=office-pia
  /// </remarks>
  public bool ShowLegendKey { get; set; }
  /// <summary>
  /// Gets or sets the `Type` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.type?view=office-pia
  /// </remarks>
  public object Type { get; set; }
  /// <summary>
  /// Gets or sets the `Position` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.position?view=office-pia
  /// </remarks>
  public XlDataLabelPosition Position { get; set; }
  /// <summary>
  /// Gets or sets the `ShowSeriesName` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.showseriesname?view=office-pia
  /// </remarks>
  public bool ShowSeriesName { get; set; }
  /// <summary>
  /// Gets or sets the `ShowCategoryName` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.showcategoryname?view=office-pia
  /// </remarks>
  public bool ShowCategoryName { get; set; }
  /// <summary>
  /// Gets or sets the `ShowValue` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.showvalue?view=office-pia
  /// </remarks>
  public bool ShowValue { get; set; }
  /// <summary>
  /// Gets or sets the `ShowPercentage` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.showpercentage?view=office-pia
  /// </remarks>
  public bool ShowPercentage { get; set; }
  /// <summary>
  /// Gets or sets the `ShowBubbleSize` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.showbubblesize?view=office-pia
  /// </remarks>
  public bool ShowBubbleSize { get; set; }
  /// <summary>
  /// Gets or sets the `Separator` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.separator?view=office-pia
  /// </remarks>
  public object Separator { get; set; }
  /// <summary>
  /// Gets the `Format` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.format?view=office-pia
  /// </remarks>
  public IMsoChartFormat Format { get; }
  /// <summary>
  /// Gets the `_Height` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel._height?view=office-pia
  /// </remarks>
  public double _Height { get; }
  /// <summary>
  /// Gets the `_Width` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel._width?view=office-pia
  /// </remarks>
  public double _Width { get; }
  /// <summary>
  /// Gets or sets the `Formula` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.formula?view=office-pia
  /// </remarks>
  public string Formula { get; set; }
  /// <summary>
  /// Gets or sets the `FormulaR1C1` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.formular1c1?view=office-pia
  /// </remarks>
  public string FormulaR1C1 { get; set; }
  /// <summary>
  /// Gets or sets the `FormulaLocal` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.formulalocal?view=office-pia
  /// </remarks>
  public string FormulaLocal { get; set; }
  /// <summary>
  /// Gets or sets the `FormulaR1C1Local` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.formular1c1local?view=office-pia
  /// </remarks>
  public string FormulaR1C1Local { get; set; }
  /// <summary>
  /// Gets or sets the `ShowRange` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.showrange?view=office-pia
  /// </remarks>
  public bool ShowRange { get; set; }
  /// <summary>
  /// Gets or sets the `Height` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.height?view=office-pia
  /// </remarks>
  public double Height { get; set; }
  /// <summary>
  /// Gets or sets the `Width` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.width?view=office-pia
  /// </remarks>
  public double Width { get; set; }
}
