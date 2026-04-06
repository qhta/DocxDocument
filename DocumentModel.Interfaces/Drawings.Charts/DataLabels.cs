using System.Collections;

namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Represents a collection of data labels.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels?view=office-pia"/>
public partial interface IDataLabels: IEnumerable
{
  /// <summary>
  /// Gets or sets the `Name` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.name?view=office-pia"/>
  public string Name { get; }
  /// <summary>
  /// Gets the `Border` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.border?view=office-pia"/>
  public IBorder Border { get; }
  /// <summary>
  /// Gets the `Interior` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.interior?view=office-pia"/>
  public Interior Interior { get; }
  /// <summary>
  /// Gets the `Fill` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.fill?view=office-pia"/>
  public IChartFillFormat Fill { get; }
  /// <summary>
  /// Gets the `Characters` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.characters?view=office-pia"/>
  public ICharacters Characters { get; }
  /// <summary>
  /// Gets the `TextFormat` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.font?view=office-pia"/>
  public IChartFont Font { get; }
  /// <summary>
  /// Gets or sets the `HorizontalAlignment` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.horizontalalignment?view=office-pia"/>
  public object HorizontalAlignment { get; set; }
  /// <summary>
  /// Gets or sets the `Orientation` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.orientation?view=office-pia"/>
  public object Orientation { get; set; }
  /// <summary>
  /// Gets or sets the `Shadow` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.shadow?view=office-pia"/>
  public bool Shadow { get; set; }
  /// <summary>
  /// Gets or sets the `VerticalAlignment` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.verticalalignment?view=office-pia"/>
  public object VerticalAlignment { get; set; }
  /// <summary>
  /// Gets or sets the `ReadingOrder` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.readingorder?view=office-pia"/>
  public int ReadingOrder { get; set; }
  /// <summary>
  /// Gets or sets the `AutoScaleFont` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.autoscalefont?view=office-pia"/>
  public object AutoScaleFont { get; set; }
  /// <summary>
  /// Gets or sets the `AutoText` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.autotext?view=office-pia"/>
  public bool AutoText { get; set; }
  /// <summary>
  /// Gets or sets the `NumberFormat` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.numberformat?view=office-pia"/>
  public string NumberFormat { get; set; }
  /// <summary>
  /// Gets or sets the `NumberFormatLinked` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.numberformatlinked?view=office-pia"/>
  public bool NumberFormatLinked { get; set; }
  /// <summary>
  /// Gets or sets the `NumberFormatLocal` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.numberformatlocal?view=office-pia"/>
  public object NumberFormatLocal { get; set; }
  /// <summary>
  /// Gets or sets the `ShowLegendKey` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.showlegendkey?view=office-pia"/>
  public bool ShowLegendKey { get; set; }
  /// <summary>
  /// Gets or sets the `Type` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.type?view=office-pia"/>
  public object Type { get; set; }
  /// <summary>
  /// Gets or sets the `Position` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.position?view=office-pia"/>
  public XlDataLabelPosition Position { get; set; }
  /// <summary>
  /// Gets or sets the `ShowSeriesName` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.showseriesname?view=office-pia"/>
  public bool ShowSeriesName { get; set; }
  /// <summary>
  /// Gets or sets the `ShowCategoryName` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.showcategoryname?view=office-pia"/>
  public bool ShowCategoryName { get; set; }
  /// <summary>
  /// Gets or sets the `ShowValue` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.showvalue?view=office-pia"/>
  public bool ShowValue { get; set; }
  /// <summary>
  /// Gets or sets the `ShowPercentage` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.showpercentage?view=office-pia"/>
  public bool ShowPercentage { get; set; }
  /// <summary>
  /// Gets or sets the `ShowBubbleSize` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.showbubblesize?view=office-pia"/>
  public bool ShowBubbleSize { get; set; }
  /// <summary>
  /// Gets or sets the `Separator` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.separator?view=office-pia"/>
  public object Separator { get; set; }
  /// <summary>
  /// Gets the `Count` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.count?view=office-pia"/>
  public int Count { get; }
  /// <summary>
  /// Gets the `Format` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.format?view=office-pia"/>
  public IChartFormat Format { get; }
  /// <summary>
  /// Gets a data label by index.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.item?view=office-pia"/>
  public IDataLabel this[object Index] { get; }
  /// <summary>
  /// Gets or sets the `ShowRange` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabels.showrange?view=office-pia"/>
  public bool ShowRange { get; set; }
}

