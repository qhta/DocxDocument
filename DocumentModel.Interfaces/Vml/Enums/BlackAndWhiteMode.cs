namespace DocumentModel.Vml;

/// <summary>
///   Black And White Modes
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum BlackAndWhiteMode
{
  /// <summary>
  ///   Color.
  /// </summary>
  Color,
  /// <summary>
  ///   Automatic.
  /// </summary>
  Auto,
  /// <summary>
  ///   Grayscale.
  /// </summary>
  GrayScale,
  /// <summary>
  ///   Light grayscale.
  /// </summary>
  LightGrayScale,
  /// <summary>
  ///   Inverse Grayscale.
  /// </summary>
  InverseGray,
  /// <summary>
  ///   Gray Outlines.
  /// </summary>
  GrayOutline,
  /// <summary>
  ///   Black And White.
  /// </summary>
  HighContrast,
  /// <summary>
  ///   Black.
  /// </summary>
  Black,
  /// <summary>
  ///   White.
  /// </summary>
  White,
  /// <summary>
  ///   Do Not Show.
  /// </summary>
  Undrawn,
  /// <summary>
  ///   Black Text And Lines.
  /// </summary>
  BlackTextAndLines
}