
namespace DocumentModel.Interfaces;

/// <summary>
/// Represents the chart area.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartarea?view=office-pia"/>
public partial interface IMsoChartArea
{
  /// <summary>
  /// Selects the chart area.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartarea.select?view=office-pia"/>
  public object Select();
  /// <summary>
  /// Clears the chart area.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartarea.clear?view=office-pia"/>
  public object Clear();
  /// <summary>
  /// Clears the contents of the chart area.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartarea.clearcontents?view=office-pia"/>
  public object ClearContents();
  /// <summary>
  /// Copies the chart area.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartarea.copy?view=office-pia"/>
  public object Copy();
  /// <summary>
  /// Clears formatting from the chart area.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartarea.clearformats?view=office-pia"/>
  public object ClearFormats();
}

