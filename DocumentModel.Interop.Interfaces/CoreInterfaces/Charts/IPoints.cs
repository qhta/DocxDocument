using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the collection of all chart points in a series.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.points?view=office-pia"/>
public interface IPoints: IEnumerable
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
  public IChartPoint this[int Index] { get; }


  #region methods

/// <summary>
  /// Returns an enumerator that iterates through the collection.
  /// </summary>
  /// <returns>An enumerator for the points collection.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.points.getenumerator?view=office-pia"/>
  public new IEnumerator GetEnumerator();

  #endregion methods
}

