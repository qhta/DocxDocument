
namespace DocumentModel.Interop.Core;

/// <summary>
/// A collection of all Axis objects in the specified chart.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.axes?view=office-pia
/// </remarks>
public partial interface Axes
{
  /// <summary>
  /// Gets the `Count` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.axes.count?view=office-pia
  /// </remarks>
  public int Count { get; }

  /// <summary>
  /// Gets an axis by type and axis group.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.axes.item?view=office-pia
  /// </remarks>
  public IMsoAxis Item { get; }

  /// <summary>
  /// Gets an enumerator for the axes collection.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.axes._newenum?view=office-pia
  /// </remarks>
  public object _NewEnum { get; }
}
