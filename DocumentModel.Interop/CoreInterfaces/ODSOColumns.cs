
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of fields in a data source.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsocolumns?view=office-pia
/// </remarks>
public partial interface ODSOColumns: InteropObject
{
  /// <summary>
  /// Gets the `Count` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsocolumns.count?view=office-pia
  /// </remarks>
  public int Count { get; }
}
