
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents chart grid lines.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.gridlines?view=office-pia"/>
public partial interface IGridLines
{
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.gridlines.name?view=office-pia"/>
  public string Name { get; }
  /// <summary>
  /// Gets the `Border` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.gridlines.border?view=office-pia"/>
  public IMsoBorder Border { get; }
  /// <summary>
  /// Gets the `Format` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.gridlines.format?view=office-pia"/>
  public MsoChartFormat Format { get; }


  #region methods

/// <summary>
  /// Selects the grid lines.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.gridlines.select?view=office-pia"/>
  public object Select();
  /// <summary>
  /// Deletes the grid lines.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.gridlines.delete?view=office-pia"/>
  public object Delete();

  #endregion methods
}

