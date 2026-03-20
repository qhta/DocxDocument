
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the chart area.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartarea?view=office-pia
/// </remarks>
public partial interface IMsoChartArea
{
  /// <summary>
  /// Selects the chart area.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartarea.select?view=office-pia
  /// </remarks>
  public object Select();
  /// <summary>
  /// Clears the chart area.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartarea.clear?view=office-pia
  /// </remarks>
  public object Clear();
  /// <summary>
  /// Clears the contents of the chart area.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartarea.clearcontents?view=office-pia
  /// </remarks>
  public object ClearContents();
  /// <summary>
  /// Copies the chart area.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartarea.copy?view=office-pia
  /// </remarks>
  public object Copy();
  /// <summary>
  /// Clears formatting from the chart area.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartarea.clearformats?view=office-pia
  /// </remarks>
  public object ClearFormats();
}
