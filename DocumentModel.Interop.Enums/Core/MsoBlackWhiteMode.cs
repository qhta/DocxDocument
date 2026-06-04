namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies how a shape appears when viewed in black-and-white mode.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoblackwhitemode?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoBlackWhiteMode")]
public enum BlackWhiteMode
{
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("msoBlackWhiteMixed")]
  Mixed = -2,
  /// <summary>
  /// Default behavior.
  /// </summary>
  [InteropEnumValue("msoBlackWhiteAutomatic")]
  Automatic = 1,
  /// <summary>
  /// Grayscale.
  /// </summary>
  [InteropEnumValue("msoBlackWhiteGrayScale")]
  GrayScale = 2,
  /// <summary>
  /// Light grayscale.
  /// </summary>
  [InteropEnumValue("msoBlackWhiteLightGrayScale")]
  LightGrayScale = 3,
  /// <summary>
  /// Inverse grayscale.
  /// </summary>
  [InteropEnumValue("msoBlackWhiteInverseGrayScale")]
  InverseGrayScale = 4,
  /// <summary>
  /// Gray with white fill.
  /// </summary>
  [InteropEnumValue("msoBlackWhiteGrayOutline")]
  GrayOutline = 5,
  /// <summary>
  /// White with grayscale fill.
  /// </summary>
  [InteropEnumValue("msoBlackWhiteBlackTextAndLine")]
  BlackTextAndLine = 6,
  /// <summary>
  /// Black with white fill.
  /// </summary>
  [InteropEnumValue("msoBlackWhiteHighContrast")]
  HighContrast = 7,
  /// <summary>
  /// Not shown.
  /// </summary>
  [InteropEnumValue("msoBlackWhiteBlack")]
  Black = 8,
  /// <summary>
  /// White.
  /// </summary>
  [InteropEnumValue("msoBlackWhiteWhite")]
  White = 9,
  /// <summary>
  /// Not shown.
  /// </summary>
  [InteropEnumValue("msoBlackWhiteDontShow")]
  DontShow = 10
}
