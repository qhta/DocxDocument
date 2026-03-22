namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the color transformation applied to a picture.
/// </summary>
public enum MsoPictureColorType
{
  /// <summary>
  /// Specifies the color transformation applied to a picture.
  /// </summary>
  msoPictureMixed = -2,
  /// <summary>
  /// Default color transformation.
  /// </summary>
  msoPictureAutomatic = 1,
  /// <summary>
  /// Grayscale transformation.
  /// </summary>
  msoPictureGrayscale = 2,
  /// <summary>
  /// Black-and-white transformation.
  /// </summary>
  msoPictureBlackAndWhite = 3,
  /// <summary>
  /// Watermark transformation.
  /// </summary>
  msoPictureWatermark = 4
}
