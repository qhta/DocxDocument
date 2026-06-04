namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies how a shape appears when viewed in black-and-white mode.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoblackwhitemode?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoBlackWhiteMode))]
public enum BlackWhiteMode
{
  /// <summary>
  /// Not supported.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBlackWhiteMode.msoBlackWhiteMixed))]
  Mixed = -2,
  /// <summary>
  /// Default behavior.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBlackWhiteMode.msoBlackWhiteAutomatic))]
  Automatic = 1,
  /// <summary>
  /// Grayscale.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBlackWhiteMode.msoBlackWhiteGrayScale))]
  GrayScale = 2,
  /// <summary>
  /// Light grayscale.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBlackWhiteMode.msoBlackWhiteLightGrayScale))]
  LightGrayScale = 3,
  /// <summary>
  /// Inverse grayscale.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBlackWhiteMode.msoBlackWhiteInverseGrayScale))]
  InverseGrayScale = 4,
  /// <summary>
  /// Gray with white fill.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBlackWhiteMode.msoBlackWhiteGrayOutline))]
  GrayOutline = 5,
  /// <summary>
  /// White with grayscale fill.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBlackWhiteMode.msoBlackWhiteBlackTextAndLine))]
  BlackTextAndLine = 6,
  /// <summary>
  /// Black with white fill.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBlackWhiteMode.msoBlackWhiteHighContrast))]
  HighContrast = 7,
  /// <summary>
  /// Not shown.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBlackWhiteMode.msoBlackWhiteBlack))]
  Black = 8,
  /// <summary>
  /// White.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBlackWhiteMode.msoBlackWhiteWhite))]
  White = 9,
  /// <summary>
  /// Not shown.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBlackWhiteMode.msoBlackWhiteDontShow))]
  DontShow = 10
}
