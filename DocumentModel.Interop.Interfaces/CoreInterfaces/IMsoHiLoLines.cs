
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents high-low lines in a chart.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsohilolines?view=office-pia"/>
public interface IMsoHiLoLines
{
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsohilolines.name?view=office-pia"/>
  public string Name { get; }
  /// <summary>
  /// Gets the `Border` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsohilolines.border?view=office-pia"/>
  public IMsoBorder Border { get; }
  /// <summary>
  /// Gets the `Format` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsohilolines.format?view=office-pia"/>
  public IMsoChartFormat Format { get; }


  #region methods

/// <summary>
  /// Selects the high-low lines.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsohilolines.select?view=office-pia"/>
  public void Select();
  /// <summary>
  /// Deletes the high-low lines.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsohilolines.delete?view=office-pia"/>
  public void Delete();

  #endregion methods
}

