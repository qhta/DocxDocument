
namespace DocumentModel;

/// <summary>
/// Specifies whether files Iin a FileSearch object's FoundFiles collection should be sorted Iin ascending or
/// descending order.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msosortorder?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum SortOrder
{
  /// <summary>
  /// Ascending order.
  /// </summary>
  Ascending = 1,
  /// <summary>
  /// Descending order.
  /// </summary>
  Descending
}

