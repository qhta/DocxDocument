
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `ODSOColumns` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsocolumns?view=office-pia` for Office interop details.
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
