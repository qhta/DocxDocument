namespace DocumentModel.Interop.Core;

/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoclipboardformat?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoClipboardFormat")]
public enum ClipboardFormat
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoClipboardFormatMixed")]
  Mixed = -2,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoClipboardFormatNative")]
  Native = 1,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoClipboardFormatHTML")]
  HTML = 2,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoClipboardFormatRTF")]
  RTF = 3,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoClipboardFormatPlainText")]
  PlainText = 4
}
