
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `IMsoTrendline` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsotrendline?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IMsoTrendline
{
  /// <summary>
  /// Gets or sets the `Backward` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsotrendline.backward?view=office-pia
  /// </remarks>
  public double Backward { get; set; }
  /// <summary>
  /// Gets the `Border` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsotrendline.border?view=office-pia
  /// </remarks>
  public IMsoBorder Border { get; }
  /// <summary>
  /// Gets the `DataLabel` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsotrendline.datalabel?view=office-pia
  /// </remarks>
  public IMsoDataLabel DataLabel { get; }
  /// <summary>
  /// Gets or sets the `DisplayEquation` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsotrendline.displayequation?view=office-pia
  /// </remarks>
  public bool DisplayEquation { get; set; }
  /// <summary>
  /// Gets or sets the `DisplayRSquared` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsotrendline.displayrsquared?view=office-pia
  /// </remarks>
  public bool DisplayRSquared { get; set; }
  /// <summary>
  /// Gets or sets the `Forward` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsotrendline.forward?view=office-pia
  /// </remarks>
  public double Forward { get; set; }
  /// <summary>
  /// Gets the `Index` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsotrendline.index?view=office-pia
  /// </remarks>
  public int Index { get; }
  /// <summary>
  /// Gets or sets the `Intercept` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsotrendline.intercept?view=office-pia
  /// </remarks>
  public double Intercept { get; set; }
  /// <summary>
  /// Gets or sets the `InterceptIsAuto` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsotrendline.interceptisauto?view=office-pia
  /// </remarks>
  public bool InterceptIsAuto { get; set; }
  /// <summary>
  /// Gets or sets the `Name` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsotrendline.name?view=office-pia
  /// </remarks>
  public string Name { get; set; }
  /// <summary>
  /// Gets or sets the `NameIsAuto` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsotrendline.nameisauto?view=office-pia
  /// </remarks>
  public bool NameIsAuto { get; set; }
  /// <summary>
  /// Gets or sets the `Order` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsotrendline.order?view=office-pia
  /// </remarks>
  public int Order { get; set; }
  /// <summary>
  /// Gets or sets the `Period` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsotrendline.period?view=office-pia
  /// </remarks>
  public int Period { get; set; }
  /// <summary>
  /// Gets or sets the `Type` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsotrendline.type?view=office-pia
  /// </remarks>
  public XlTrendlineType Type { get; set; }
  /// <summary>
  /// Gets the `Format` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsotrendline.format?view=office-pia
  /// </remarks>
  public IMsoChartFormat Format { get; }
  /// <summary>
  /// Gets or sets the `Backward2` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsotrendline.backward2?view=office-pia
  /// </remarks>
  public double Backward2 { get; set; }
  /// <summary>
  /// Gets or sets the `Forward2` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsotrendline.forward2?view=office-pia
  /// </remarks>
  public double Forward2 { get; set; }
}
