
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Represents tick labels on a chart axis.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoticklabels?view=office-pia"/>
public partial interface ITickLabels: IModelObject
{
  /// <summary>
  /// Gets or sets the `TextFormat` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoticklabels.font?view=office-pia"/>
  public IChartFont Font { get; }
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoticklabels.name?view=office-pia"/>
  public string Name { get; }
  /// <summary>
  /// Gets or sets the `NumberFormat` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoticklabels.numberformat?view=office-pia"/>
  public string NumberFormat { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `NumberFormatLinked` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoticklabels.numberformatlinked?view=office-pia"/>
  public bool NumberFormatLinked { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `NumberFormatLocal` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoticklabels.numberformatlocal?view=office-pia"/>
  public object NumberFormatLocal { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `Orientation` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoticklabels.orientation?view=office-pia"/>
  public XlTickLabelOrientation Orientation { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `ReadingOrder` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoticklabels.readingorder?view=office-pia"/>
  public int ReadingOrder { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `AutoScaleFont` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoticklabels.autoscalefont?view=office-pia"/>
  public object AutoScaleFont { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets the `Depth` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoticklabels.depth?view=office-pia"/>
  public int Depth { get; }
  /// <summary>
  /// Gets or sets the `Offset` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoticklabels.offset?view=office-pia"/>
  public int Offset { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `Alignment` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoticklabels.alignment?view=office-pia"/>
  public int Alignment { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `MultiLevel` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoticklabels.multilevel?view=office-pia"/>
  public bool MultiLevel { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets the `Format` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoticklabels.format?view=office-pia"/>
  public IChartFormat Format { get; }
}

