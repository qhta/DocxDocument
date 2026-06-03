
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents error bars in a chart.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoerrorbars?view=office-pia"/>
public interface IMsoErrorBars
{
  /// <summary>
  /// Gets or sets the `Name` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoerrorbars.name?view=office-pia"/>
  public string Name { get; }
  /// <summary>
  /// Gets the `Border` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoerrorbars.border?view=office-pia"/>
  public IMsoBorder Border { get; }
  /// <summary>
  /// Gets or sets the `EndStyle` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoerrorbars.endstyle?view=office-pia"/>
  public EndStyleCap EndStyle { get; set; }
  /// <summary>
  /// Gets the `Format` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoerrorbars.format?view=office-pia"/>
  public IMsoChartFormat Format { get; }


  #region methods

/// <summary>
  /// Selects the error bars.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoerrorbars.select?view=office-pia"/>
  public object Select();
  /// <summary>
  /// Deletes the error bars.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoerrorbars.delete?view=office-pia"/>
  public object Delete();
  /// <summary>
  /// Clears formatting from the error bars.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoerrorbars.clearformats?view=office-pia"/>
  public object ClearFormats();

  #endregion methods
}

