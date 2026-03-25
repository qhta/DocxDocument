
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of fields in a data source.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsocolumns?view=office-pia"/>
public partial interface ODSOColumns: InteropObject
{
  /// <summary>
  /// Returns a field from the collection.
  /// </summary>
  /// <param name="varIndex">The `varIndex` parameter.</param>
  /// <returns>The requested field object.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsocolumns.item?view=office-pia"/>
  public object Item(object varIndex);
}

