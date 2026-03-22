namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the format for the Clipboard contents when they are inserted into a document.
/// </summary>
public enum WdPasteDataType
{
  /// <summary>
  /// OLE object.
  /// </summary>
  wdPasteOLEObject = unchecked((int)0),
  /// <summary>
  /// Rich Text Format (RTF).
  /// </summary>
  wdPasteRTF = unchecked((int)1),
  /// <summary>
  /// Text.
  /// </summary>
  wdPasteText = unchecked((int)2),
  /// <summary>
  /// Metafile picture.
  /// </summary>
  wdPasteMetafilePicture = unchecked((int)3),
  /// <summary>
  /// Bitmap.
  /// </summary>
  wdPasteBitmap = unchecked((int)4),
  /// <summary>
  /// Device-independent bitmap.
  /// </summary>
  wdPasteDeviceIndependentBitmap = unchecked((int)5),
  /// <summary>
  /// Hyperlink.
  /// </summary>
  wdPasteHyperlink = unchecked((int)7),
  /// <summary>
  /// Shape.
  /// </summary>
  wdPasteShape = unchecked((int)8),
  /// <summary>
  /// Enhanced metafile.
  /// </summary>
  wdPasteEnhancedMetafile = unchecked((int)9),
  /// <summary>
  /// HTML. [System.Runtime.InteropServices.Guid("773B6CF3-4435-343F-BA19-8F0B7D78CC67")] public enum
  /// WdPasteDataType ﾉ Expand table
  /// </summary>
  wdPasteHTML = unchecked((int)10)
}
