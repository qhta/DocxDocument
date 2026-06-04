namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the color transformation applied to a picture.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopicturecolortype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoPictureColorType")]
public enum PictureColorType
{
  /// <summary>
  /// Mixed transformation.
  /// </summary>
  [OfficeInteropEnumValue("msoPictureMixed")]
  Mixed = -2,
  /// <summary>
  /// Default color transformation.
  /// </summary>
  [OfficeInteropEnumValue("msoPictureAutomatic")]
  Automatic = 1,
  /// <summary>
  /// Grayscale transformation.
  /// </summary>
  [OfficeInteropEnumValue("msoPictureGrayscale")]
  Grayscale = 2,
  /// <summary>
  /// Black-and-white transformation.
  /// </summary>
  [OfficeInteropEnumValue("msoPictureBlackAndWhite")]
  BlackAndWhite = 3,
  /// <summary>
  /// Watermark transformation.
  /// </summary>
  [OfficeInteropEnumValue("msoPictureWatermark")]
  Watermark = 4
}
