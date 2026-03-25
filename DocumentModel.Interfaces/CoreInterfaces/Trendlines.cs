using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `Trendlines` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.trendlines?view=office-pia"/>
public partial interface Trendlines: IEnumerable
{
  /// <summary>
  /// Gets the `Count` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.trendlines.count?view=office-pia"/>
  public int Count { get; }
  /// <summary>
  /// Gets the trendline at the specified index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.trendlines.item?view=office-pia"/>
  public IMsoTrendline this[object Index] { get; }
}

