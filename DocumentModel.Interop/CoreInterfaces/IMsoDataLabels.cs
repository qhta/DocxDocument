using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `IMsoDataLabels` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IMsoDataLabels: IEnumerable
{
  /// <summary>
  /// Gets or sets the `Name` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.name?view=office-pia
  /// </remarks>
  public string Name { get; }
  /// <summary>
  /// Gets the `Border` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.border?view=office-pia
  /// </remarks>
  public IMsoBorder Border { get; }
  /// <summary>
  /// Gets the `Interior` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.interior?view=office-pia
  /// </remarks>
  public IMsoInterior Interior { get; }
  /// <summary>
  /// Gets the `Fill` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.fill?view=office-pia
  /// </remarks>
  public ChartFillFormat Fill { get; }
  /// <summary>
  /// Gets the `Characters` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.characters?view=office-pia
  /// </remarks>
  public IMsoCharacters Characters { get; }
  /// <summary>
  /// Gets the `Font` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.font?view=office-pia
  /// </remarks>
  public ChartFont Font { get; }
  /// <summary>
  /// Gets or sets the `HorizontalAlignment` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.horizontalalignment?view=office-pia
  /// </remarks>
  public object HorizontalAlignment { get; set; }
  /// <summary>
  /// Gets or sets the `Orientation` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.orientation?view=office-pia
  /// </remarks>
  public object Orientation { get; set; }
  /// <summary>
  /// Gets or sets the `Shadow` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.shadow?view=office-pia
  /// </remarks>
  public bool Shadow { get; set; }
  /// <summary>
  /// Gets or sets the `VerticalAlignment` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.verticalalignment?view=office-pia
  /// </remarks>
  public object VerticalAlignment { get; set; }
  /// <summary>
  /// Gets or sets the `ReadingOrder` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.readingorder?view=office-pia
  /// </remarks>
  public int ReadingOrder { get; set; }
  /// <summary>
  /// Gets or sets the `AutoScaleFont` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.autoscalefont?view=office-pia
  /// </remarks>
  public object AutoScaleFont { get; set; }
  /// <summary>
  /// Gets or sets the `AutoText` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.autotext?view=office-pia
  /// </remarks>
  public bool AutoText { get; set; }
  /// <summary>
  /// Gets or sets the `NumberFormat` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.numberformat?view=office-pia
  /// </remarks>
  public string NumberFormat { get; set; }
  /// <summary>
  /// Gets or sets the `NumberFormatLinked` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.numberformatlinked?view=office-pia
  /// </remarks>
  public bool NumberFormatLinked { get; set; }
  /// <summary>
  /// Gets or sets the `NumberFormatLocal` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.numberformatlocal?view=office-pia
  /// </remarks>
  public object NumberFormatLocal { get; set; }
  /// <summary>
  /// Gets or sets the `ShowLegendKey` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.showlegendkey?view=office-pia
  /// </remarks>
  public bool ShowLegendKey { get; set; }
  /// <summary>
  /// Gets or sets the `Type` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.type?view=office-pia
  /// </remarks>
  public object Type { get; set; }
  /// <summary>
  /// Gets or sets the `Position` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.position?view=office-pia
  /// </remarks>
  public XlDataLabelPosition Position { get; set; }
  /// <summary>
  /// Gets or sets the `ShowSeriesName` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.showseriesname?view=office-pia
  /// </remarks>
  public bool ShowSeriesName { get; set; }
  /// <summary>
  /// Gets or sets the `ShowCategoryName` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.showcategoryname?view=office-pia
  /// </remarks>
  public bool ShowCategoryName { get; set; }
  /// <summary>
  /// Gets or sets the `ShowValue` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.showvalue?view=office-pia
  /// </remarks>
  public bool ShowValue { get; set; }
  /// <summary>
  /// Gets or sets the `ShowPercentage` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.showpercentage?view=office-pia
  /// </remarks>
  public bool ShowPercentage { get; set; }
  /// <summary>
  /// Gets or sets the `ShowBubbleSize` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.showbubblesize?view=office-pia
  /// </remarks>
  public bool ShowBubbleSize { get; set; }
  /// <summary>
  /// Gets or sets the `Separator` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.separator?view=office-pia
  /// </remarks>
  public object Separator { get; set; }
  /// <summary>
  /// Gets the `Count` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.count?view=office-pia
  /// </remarks>
  public int Count { get; }
  /// <summary>
  /// Gets the `Format` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.format?view=office-pia
  /// </remarks>
  public IMsoChartFormat Format { get; }
  public IMsoDataLabel this[object Index] { get; }
  /// <summary>
  /// Gets or sets the `ShowRange` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.showrange?view=office-pia
  /// </remarks>
  public bool ShowRange { get; set; }
}
