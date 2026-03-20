
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `IMsoDataTable` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatatable?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IMsoDataTable
{
  /// <summary>
  /// Invokes `Select`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatatable.select?view=office-pia
  /// </remarks>
  public void Select();
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatatable.delete?view=office-pia
  /// </remarks>
  public void Delete();
}
