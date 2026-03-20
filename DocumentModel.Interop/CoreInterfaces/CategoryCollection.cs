
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the collection of visible chart categories in a chart.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.categorycollection?view=office-pia
/// </remarks>
public partial interface CategoryCollection
{
  /// <summary>
  /// Gets the number of visible categories in the collection.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.categorycollection.count?view=office-pia
  /// </remarks>
  public int Count { get; }

  /// <summary>
  /// Gets a category from the collection by index.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.categorycollection.item?view=office-pia
  /// </remarks>
  public IMsoCategory this[object Index] { get; }
}
