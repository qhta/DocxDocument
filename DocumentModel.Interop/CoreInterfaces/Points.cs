using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `Points` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.points?view=office-pia` for Office interop details.
/// </remarks>
public partial interface Points: IEnumerable
{
  /// <summary>
  /// Gets the `Count` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.points.count?view=office-pia
  /// </remarks>
  public int Count { get; }
  public ChartPoint this[int Index] { get; }
}
