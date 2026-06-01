
namespace DocumentModel.Interop.Core;

/// <summary>
/// A collection of all Axis objects in the specified chart.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.axes?view=office-pia"/>
public partial class Axes
{
  /// <summary>
  /// Gets the `Count` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.axes.count?view=office-pia"/>
  public int Count { get; }

  /// <summary>
  /// Gets an axis by type and axis group.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.axes.item?view=office-pia"/>
  public MsoAxis Item { get; }

  /// <summary>
  /// Gets an enumerator for the axes collection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.axes._newenum?view=office-pia"/>
  public object _NewEnum { get; }
}

