
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a trendline in a chart.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsotrendline?view=office-pia"/>
public partial interface IMsoTrendline
{
  /// <summary>
  /// Gets or sets the `Backward` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsotrendline.backward?view=office-pia"/>
  public double Backward { get; set; }
  /// <summary>
  /// Gets the `Border` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsotrendline.border?view=office-pia"/>
  public IMsoBorder Border { get; }
  /// <summary>
  /// Gets the `DataLabel` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsotrendline.datalabel?view=office-pia"/>
  public MsoDataLabel DataLabel { get; }
  /// <summary>
  /// Gets or sets the `DisplayEquation` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsotrendline.displayequation?view=office-pia"/>
  public bool DisplayEquation { get; set; }
  /// <summary>
  /// Gets or sets the `DisplayRSquared` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsotrendline.displayrsquared?view=office-pia"/>
  public bool DisplayRSquared { get; set; }
  /// <summary>
  /// Gets or sets the `Forward` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsotrendline.forward?view=office-pia"/>
  public double Forward { get; set; }
  /// <summary>
  /// Gets the `Index` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsotrendline.index?view=office-pia"/>
  public int Index { get; }
  /// <summary>
  /// Gets or sets the `Intercept` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsotrendline.intercept?view=office-pia"/>
  public double Intercept { get; set; }
  /// <summary>
  /// Gets or sets the `InterceptIsAuto` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsotrendline.interceptisauto?view=office-pia"/>
  public bool InterceptIsAuto { get; set; }
  /// <summary>
  /// Gets or sets the `Name` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsotrendline.name?view=office-pia"/>
  public string Name { get; set; }
  /// <summary>
  /// Gets or sets the `NameIsAuto` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsotrendline.nameisauto?view=office-pia"/>
  public bool NameIsAuto { get; set; }
  /// <summary>
  /// Gets or sets the `Order` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsotrendline.order?view=office-pia"/>
  public int Order { get; set; }
  /// <summary>
  /// Gets or sets the `Period` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsotrendline.period?view=office-pia"/>
  public int Period { get; set; }
  /// <summary>
  /// Gets or sets the `Type` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsotrendline.type?view=office-pia"/>
  public TrendlineType Type { get; set; }
  /// <summary>
  /// Gets the `Format` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsotrendline.format?view=office-pia"/>
  public MsoChartFormat Format { get; }
  /// <summary>
  /// Gets or sets the `Backward2` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsotrendline.backward2?view=office-pia"/>
  public double Backward2 { get; set; }
  /// <summary>
  /// Gets or sets the `Forward2` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsotrendline.forward2?view=office-pia"/>
  public double Forward2 { get; set; }
}

