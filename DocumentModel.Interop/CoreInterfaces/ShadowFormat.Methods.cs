
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `ShadowFormat` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shadowformat?view=office-pia` for Office interop details.
/// </remarks>
public partial interface ShadowFormat
{
  /// <summary>
  /// Invokes `IncrementOffsetX`.
  /// </summary>
  /// <param name="Increment">The `Increment` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shadowformat.incrementoffsetx?view=office-pia
  /// </remarks>
  public void IncrementOffsetX(float Increment);
  /// <summary>
  /// Invokes `IncrementOffsetY`.
  /// </summary>
  /// <param name="Increment">The `Increment` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shadowformat.incrementoffsety?view=office-pia
  /// </remarks>
  public void IncrementOffsetY(float Increment);
}
