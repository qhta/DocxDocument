namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies how a shape appears when viewed in black-and-white mode.
/// </summary>
public enum MsoBlackWhiteMode
{
  /// <summary>
  /// Specifies how a shape appears when viewed in black-and-white mode.
  /// </summary>
  msoBlackWhiteMixed = -2,
  /// <summary>
  /// Default behavior.
  /// </summary>
  msoBlackWhiteAutomatic = 1,
  /// <summary>
  /// Grayscale.
  /// </summary>
  msoBlackWhiteGrayScale = 2,
  /// <summary>
  /// Light grayscale.
  /// </summary>
  msoBlackWhiteLightGrayScale = 3,
  /// <summary>
  /// Inverse grayscale.
  /// </summary>
  msoBlackWhiteInverseGrayScale = 4,
  /// <summary>
  /// Gray with white fill.
  /// </summary>
  msoBlackWhiteGrayOutline = 5,
  /// <summary>
  /// White with grayscale fill.
  /// </summary>
  msoBlackWhiteBlackTextAndLine = 6,
  /// <summary>
  /// Black with white fill.
  /// </summary>
  msoBlackWhiteHighContrast = 7,
  /// <summary>
  /// Black.
  /// </summary>
  msoBlackWhiteBlack = 8,
  /// <summary>
  /// White.
  /// </summary>
  msoBlackWhiteWhite = 9,
  /// <summary>
  /// Not shown.
  /// </summary>
  msoBlackWhiteDontShow = 10
}
