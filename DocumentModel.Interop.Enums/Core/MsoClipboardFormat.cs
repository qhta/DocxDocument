namespace DocumentModel.Interop.Core;

/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoclipboardformat?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoClipboardFormat")]
public enum ClipboardFormat
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoClipboardFormatMixed")]
  Mixed = -2,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoClipboardFormatNative")]
  Native = 1,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoClipboardFormatHTML")]
  HTML = 2,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoClipboardFormatRTF")]
  RTF = 3,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoClipboardFormatPlainText")]
  PlainText = 4
}
