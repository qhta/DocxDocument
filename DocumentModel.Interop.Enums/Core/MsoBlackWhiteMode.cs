namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies how a shape appears when viewed in black-and-white mode.
/// </summary>
public enum MsoBlackWhiteMode
{
  /// <summary>
  /// Specifies how a shape appears when viewed in black-and-white mode.
  /// </summary>
  Mixed = -2,
  /// <summary>
  /// Default behavior.
  /// </summary>
  Automatic = 1,
  /// <summary>
  /// Grayscale.
  /// </summary>
  GrayScale = 2,
  /// <summary>
  /// Light grayscale.
  /// </summary>
  LightGrayScale = 3,
  /// <summary>
  /// Inverse grayscale.
  /// </summary>
  InverseGrayScale = 4,
  /// <summary>
  /// Gray with white fill.
  /// </summary>
  GrayOutline = 5,
  /// <summary>
  /// White with grayscale fill.
  /// </summary>
  BlackTextAndLine = 6,
  /// <summary>
  /// Black with white fill.
  /// </summary>
  HighContrast = 7,
  /// <summary>
  /// Black.
  /// </summary>
  Black = 8,
  /// <summary>
  /// White.
  /// </summary>
  White = 9,
  /// <summary>
  /// Not shown.
  /// </summary>
  DontShow = 10
}
