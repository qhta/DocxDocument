namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the format for the Clipboard contents when they are inserted into a document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdpastedatatype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdPasteDataType))]
public enum PasteDataType
{
  /// <summary>
  /// OLE object.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPasteDataType.wdPasteOLEObject))]
  OLEObject = 0,
  /// <summary>
  /// Rich Text Format (RTF).
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPasteDataType.wdPasteRTF))]
  RTF = 1,
  /// <summary>
  /// Text.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPasteDataType.wdPasteText))]
  Text = 2,
  /// <summary>
  /// Metafile picture.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPasteDataType.wdPasteMetafilePicture))]
  MetafilePicture = 3,
  /// <summary>
  /// Bitmap.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPasteDataType.wdPasteBitmap))]
  Bitmap = 4,
  /// <summary>
  /// Device-independent bitmap.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPasteDataType.wdPasteDeviceIndependentBitmap))]
  DeviceIndependentBitmap = 5,
  /// <summary>
  /// Hyperlink.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPasteDataType.wdPasteHyperlink))]
  Hyperlink = 7,
  /// <summary>
  /// Shape.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPasteDataType.wdPasteShape))]
  Shape = 8,
  /// <summary>
  /// Enhanced metafile.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPasteDataType.wdPasteEnhancedMetafile))]
  EnhancedMetafile = 9,
  /// <summary>
  /// HTML.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPasteDataType.wdPasteHTML))]
  HTML = 10
}
