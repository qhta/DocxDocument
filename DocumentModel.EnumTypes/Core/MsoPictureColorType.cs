namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the color transformation applied to a picture.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopicturecolortype?view=office-pia` for Office interop details.
/// </remarks>
public enum PictureColorType
{
  /// <summary>
  /// Mixed transformation.
  /// </summary>
  /// <summary>
  /// Default color transformation.
  /// </summary>
  Automatic = 1,
  /// <summary>
  /// Grayscale transformation.
  /// </summary>
  Grayscale = 2,
  /// <summary>
  /// Black-and-white transformation.
  /// </summary>
  BlackAndWhite = 3,
  /// <summary>
  /// Watermark transformation.
  /// </summary>
  Watermark = 4
}
