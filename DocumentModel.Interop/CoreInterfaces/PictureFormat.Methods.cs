
namespace DocumentModel.Interop.Core;

/// <summary>
/// Contains properties for formatting pictures and OLE objects.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureformat?view=office-pia
/// </remarks>
public partial interface PictureFormat
{
  /// <summary>
  /// Changes the picture brightness by the specified amount.
  /// </summary>
  /// <param name="Increment">The `Increment` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureformat.incrementbrightness?view=office-pia
  /// </remarks>
  public void IncrementBrightness(float Increment);
  /// <summary>
  /// Changes the picture contrast by the specified amount.
  /// </summary>
  /// <param name="Increment">The `Increment` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureformat.incrementcontrast?view=office-pia
  /// </remarks>
  public void IncrementContrast(float Increment);
}
