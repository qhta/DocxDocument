
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents all filters applied to the attached mail merge data source.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsofilters?view=office-pia
/// </remarks>
public partial interface ODSOFilters: InteropObject
{
  /// <summary>
  /// Gets the `Count` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsofilters.count?view=office-pia
  /// </remarks>
  public int Count { get; }
}
