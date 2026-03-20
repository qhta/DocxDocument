
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `PictureFormat` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureformat?view=office-pia` for Office interop details.
/// </remarks>
public partial interface PictureFormat
{
  /// <summary>
  /// Invokes `IncrementBrightness`.
  /// </summary>
  /// <param name="Increment">The `Increment` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureformat.incrementbrightness?view=office-pia
  /// </remarks>
  public void IncrementBrightness(float Increment);
  /// <summary>
  /// Invokes `IncrementContrast`.
  /// </summary>
  /// <param name="Increment">The `Increment` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureformat.incrementcontrast?view=office-pia
  /// </remarks>
  public void IncrementContrast(float Increment);
}
