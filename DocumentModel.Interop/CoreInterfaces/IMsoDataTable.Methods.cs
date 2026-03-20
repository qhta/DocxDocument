
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a chart data table.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatatable?view=office-pia
/// </remarks>
public partial interface IMsoDataTable
{
  /// <summary>
  /// Selects the data table.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatatable.select?view=office-pia
  /// </remarks>
  public void Select();
  /// <summary>
  /// Deletes the data table.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatatable.delete?view=office-pia
  /// </remarks>
  public void Delete();
}
