namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the format for the Clipboard contents when they are inserted into a document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdpastedatatype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdPasteDataType")]
public enum PasteDataType
{
  /// <summary>
  /// OLE object.
  /// </summary>
  [WordInteropEnumValue("wdPasteOLEObject")]
  OLEObject = 0,
  /// <summary>
  /// Rich Text Format (RTF).
  /// </summary>
  [WordInteropEnumValue("wdPasteRTF")]
  RTF = 1,
  /// <summary>
  /// Text.
  /// </summary>
  [WordInteropEnumValue("wdPasteText")]
  Text = 2,
  /// <summary>
  /// Metafile picture.
  /// </summary>
  [WordInteropEnumValue("wdPasteMetafilePicture")]
  MetafilePicture = 3,
  /// <summary>
  /// Bitmap.
  /// </summary>
  [WordInteropEnumValue("wdPasteBitmap")]
  Bitmap = 4,
  /// <summary>
  /// Device-independent bitmap.
  /// </summary>
  [WordInteropEnumValue("wdPasteDeviceIndependentBitmap")]
  DeviceIndependentBitmap = 5,
  /// <summary>
  /// Hyperlink.
  /// </summary>
  [WordInteropEnumValue("wdPasteHyperlink")]
  Hyperlink = 7,
  /// <summary>
  /// Shape.
  /// </summary>
  [WordInteropEnumValue("wdPasteShape")]
  Shape = 8,
  /// <summary>
  /// Enhanced metafile.
  /// </summary>
  [WordInteropEnumValue("wdPasteEnhancedMetafile")]
  EnhancedMetafile = 9,
  /// <summary>
  /// HTML.
  /// </summary>
  [WordInteropEnumValue("wdPasteHTML")]
  HTML = 10
}
