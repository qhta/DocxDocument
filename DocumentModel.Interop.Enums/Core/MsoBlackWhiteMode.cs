namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies how a shape appears when viewed in black-and-white mode.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoblackwhitemode?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoBlackWhiteMode")]
public enum BlackWhiteMode
{
  /// <summary>
  /// Not supported.
  /// </summary>
  [OfficeInteropEnumValue("msoBlackWhiteMixed")]
  Mixed = -2,
  /// <summary>
  /// Default behavior.
  /// </summary>
  [OfficeInteropEnumValue("msoBlackWhiteAutomatic")]
  Automatic = 1,
  /// <summary>
  /// Grayscale.
  /// </summary>
  [OfficeInteropEnumValue("msoBlackWhiteGrayScale")]
  GrayScale = 2,
  /// <summary>
  /// Light grayscale.
  /// </summary>
  [OfficeInteropEnumValue("msoBlackWhiteLightGrayScale")]
  LightGrayScale = 3,
  /// <summary>
  /// Inverse grayscale.
  /// </summary>
  [OfficeInteropEnumValue("msoBlackWhiteInverseGrayScale")]
  InverseGrayScale = 4,
  /// <summary>
  /// Gray with white fill.
  /// </summary>
  [OfficeInteropEnumValue("msoBlackWhiteGrayOutline")]
  GrayOutline = 5,
  /// <summary>
  /// White with grayscale fill.
  /// </summary>
  [OfficeInteropEnumValue("msoBlackWhiteBlackTextAndLine")]
  BlackTextAndLine = 6,
  /// <summary>
  /// Black with white fill.
  /// </summary>
  [OfficeInteropEnumValue("msoBlackWhiteHighContrast")]
  HighContrast = 7,
  /// <summary>
  /// Not shown.
  /// </summary>
  [OfficeInteropEnumValue("msoBlackWhiteBlack")]
  Black = 8,
  /// <summary>
  /// White.
  /// </summary>
  [OfficeInteropEnumValue("msoBlackWhiteWhite")]
  White = 9,
  /// <summary>
  /// Not shown.
  /// </summary>
  [OfficeInteropEnumValue("msoBlackWhiteDontShow")]
  DontShow = 10
}
