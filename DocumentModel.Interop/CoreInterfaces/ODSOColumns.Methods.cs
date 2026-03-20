
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of fields in a data source.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsocolumns?view=office-pia
/// </remarks>
public partial interface ODSOColumns
{
  /// <summary>
  /// Returns a field from the collection.
  /// </summary>
  /// <param name="varIndex">The `varIndex` parameter.</param>
  /// <returns>The requested field object.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsocolumns.item?view=office-pia
  /// </remarks>
  public object Item(object varIndex);
}
