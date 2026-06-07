namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the format for the Clipboard contents when they are inserted into a document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdpastedatatype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdPasteDataType")]
public enum PasteDataType
{
  /// <summary>
  /// OLE object.
  /// </summary>
  [InteropEnumValue("wdPasteOLEObject")]
  OLEObject = 0,
  /// <summary>
  /// Rich Text Format (RTF).
  /// </summary>
  [InteropEnumValue("wdPasteRTF")]
  RTF = 1,
  /// <summary>
  /// Text.
  /// </summary>
  [InteropEnumValue("wdPasteText")]
  Text = 2,
  /// <summary>
  /// Metafile picture.
  /// </summary>
  [InteropEnumValue("wdPasteMetafilePicture")]
  MetafilePicture = 3,
  /// <summary>
  /// Bitmap.
  /// </summary>
  [InteropEnumValue("wdPasteBitmap")]
  Bitmap = 4,
  /// <summary>
  /// Device-independent bitmap.
  /// </summary>
  [InteropEnumValue("wdPasteDeviceIndependentBitmap")]
  DeviceIndependentBitmap = 5,
  /// <summary>
  /// Hyperlink.
  /// </summary>
  [InteropEnumValue("wdPasteHyperlink")]
  Hyperlink = 7,
  /// <summary>
  /// Shape.
  /// </summary>
  [InteropEnumValue("wdPasteShape")]
  Shape = 8,
  /// <summary>
  /// Enhanced metafile.
  /// </summary>
  [InteropEnumValue("wdPasteEnhancedMetafile")]
  EnhancedMetafile = 9,
  /// <summary>
  /// HTML.
  /// </summary>
  [InteropEnumValue("wdPasteHTML")]
  HTML = 10
}
