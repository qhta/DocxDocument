
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents down bars in a chart.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodownbars?view=office-pia"/>
public partial interface IMsoDownBars: InteropObject
{
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodownbars.name?view=office-pia"/>
  public string Name { get; }
  /// <summary>
  /// Gets the `Border` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodownbars.border?view=office-pia"/>
  public IMsoBorder Border { get; }
  /// <summary>
  /// Gets the `Interior` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodownbars.interior?view=office-pia"/>
  public IMsoInterior Interior { get; }
  /// <summary>
  /// Gets the `Fill` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodownbars.fill?view=office-pia"/>
  public ChartFillFormat Fill { get; }
  /// <summary>
  /// Gets the `Format` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodownbars.format?view=office-pia"/>
  public IMsoChartFormat Format { get; }
}

