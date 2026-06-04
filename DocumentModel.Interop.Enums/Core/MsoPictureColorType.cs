namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the color transformation applied to a picture.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopicturecolortype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoPictureColorType")]
public enum PictureColorType
{
  /// <summary>
  /// Mixed transformation.
  /// </summary>
  [InteropEnumValue("msoPictureMixed")]
  Mixed = -2,
  /// <summary>
  /// Default color transformation.
  /// </summary>
  [InteropEnumValue("msoPictureAutomatic")]
  Automatic = 1,
  /// <summary>
  /// Grayscale transformation.
  /// </summary>
  [InteropEnumValue("msoPictureGrayscale")]
  Grayscale = 2,
  /// <summary>
  /// Black-and-white transformation.
  /// </summary>
  [InteropEnumValue("msoPictureBlackAndWhite")]
  BlackAndWhite = 3,
  /// <summary>
  /// Watermark transformation.
  /// </summary>
  [InteropEnumValue("msoPictureWatermark")]
  Watermark = 4
}
