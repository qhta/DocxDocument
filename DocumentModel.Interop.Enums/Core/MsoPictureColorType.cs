namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the color transformation applied to a picture.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopicturecolortype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoPictureColorType))]
public enum PictureColorType
{
  /// <summary>
  /// Mixed transformation.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPictureColorType.msoPictureMixed))]
  Mixed = -2,
  /// <summary>
  /// Default color transformation.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPictureColorType.msoPictureAutomatic))]
  Automatic = 1,
  /// <summary>
  /// Grayscale transformation.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPictureColorType.msoPictureGrayscale))]
  Grayscale = 2,
  /// <summary>
  /// Black-and-white transformation.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPictureColorType.msoPictureBlackAndWhite))]
  BlackAndWhite = 3,
  /// <summary>
  /// Watermark transformation.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPictureColorType.msoPictureWatermark))]
  Watermark = 4
}
