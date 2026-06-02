
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the collection of visible chart categories in a chart.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.categorycollection?view=office-pia"/>
public partial interface ICategoryCollection
{
  /// <summary>
  /// Gets the number of visible categories in the collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.categorycollection.count?view=office-pia"/>
  public int Count { get; }

  /// <summary>
  /// Gets a category from the collection by index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.categorycollection.item?view=office-pia"/>
  public IMsoCategory this[object Index] { get; }
}

