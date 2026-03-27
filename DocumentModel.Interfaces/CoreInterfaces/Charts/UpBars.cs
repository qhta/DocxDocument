
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Represents up bars in a chart.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoupbars?view=office-pia"/>
public partial interface UpBars: InteropObject
{
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoupbars.name?view=office-pia"/>
  public string Name { get; }
  /// <summary>
  /// Gets the `Border` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoupbars.border?view=office-pia"/>
  public Border Border { get; }
  /// <summary>
  /// Gets the `Interior` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoupbars.interior?view=office-pia"/>
  public Interior Interior { get; }
  /// <summary>
  /// Gets the `Fill` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoupbars.fill?view=office-pia"/>
  public ChartFillFormat Fill { get; }
  /// <summary>
  /// Gets the `Format` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoupbars.format?view=office-pia"/>
  public ChartFormat Format { get; }
}

