
namespace DocumentModel.Interfaces;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.adjustments?view=office-pia"/>
public partial interface Adjustments: InteropObject
{
  /// <summary>
  /// Gets the number of adjustment values in the collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.adjustments.count?view=office-pia"/>
  public int Count { get; }

  /// <summary>
  /// Gets or sets an adjustment value by index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.adjustments.item?view=office-pia"/>
  public float this[int Index] { get; set; }
}

