
namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.adjustments?view=office-pia
/// </remarks>
public partial interface Adjustments: InteropObject
{
  /// <summary>
  /// Gets the number of adjustment values in the collection.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.adjustments.count?view=office-pia
  /// </remarks>
  public int Count { get; }

  /// <summary>
  /// Gets or sets an adjustment value by index.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.adjustments.item?view=office-pia
  /// </remarks>
  public float this[int Index] { get; set; }
}
