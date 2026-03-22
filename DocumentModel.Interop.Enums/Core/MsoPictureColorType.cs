namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the color transformation applied to a picture.
/// </summary>
public enum MsoPictureColorType
{
  /// <summary>
  /// Specifies the color transformation applied to a picture.
  /// </summary>
  Mixed = -2,
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
