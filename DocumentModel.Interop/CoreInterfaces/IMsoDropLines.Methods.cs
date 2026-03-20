
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents drop lines in a chart.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodroplines?view=office-pia
/// </remarks>
public partial interface IMsoDropLines
{
  /// <summary>
  /// Selects the drop lines.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodroplines.select?view=office-pia
  /// </remarks>
  public void Select();
  /// <summary>
  /// Deletes the drop lines.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodroplines.delete?view=office-pia
  /// </remarks>
  public void Delete();
}
