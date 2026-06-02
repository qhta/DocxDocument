using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the collection of all chart points in a series.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.points?view=office-pia"/>
public partial interface IPoints: IEnumerable
{
  /// <summary>
  /// Gets the number of points in the collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.points.count?view=office-pia"/>
  public int Count { get; }
  /// <summary>
  /// Gets a chart point at the specified index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.points._default?view=office-pia"/>
  public ChartPoint this[int Index] { get; }
}

