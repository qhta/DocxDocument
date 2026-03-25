
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a chart data table.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatatable?view=office-pia"/>
public partial interface IMsoDataTable: InteropObject
{
  /// <summary>
  /// Selects the data table.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatatable.select?view=office-pia"/>
  public void Select();
  /// <summary>
  /// Deletes the data table.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatatable.delete?view=office-pia"/>
  public void Delete();
}

