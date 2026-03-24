namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the format for the Clipboard contents when they are inserted into a document.
/// </summary>
public enum WdPasteDataType
{
  /// <summary>
  /// OLE object.
  /// </summary>
  OLEObject = unchecked((int)0),
  /// <summary>
  /// Rich Text Format (RTF).
  /// </summary>
  RTF = unchecked((int)1),
  /// <summary>
  /// Text.
  /// </summary>
  Text = unchecked((int)2),
  /// <summary>
  /// Metafile picture.
  /// </summary>
  MetafilePicture = unchecked((int)3),
  /// <summary>
  /// Bitmap.
  /// </summary>
  Bitmap = unchecked((int)4),
  /// <summary>
  /// Device-independent bitmap.
  /// </summary>
  DeviceIndependentBitmap = unchecked((int)5),
  /// <summary>
  /// Hyperlink.
  /// </summary>
  Hyperlink = unchecked((int)7),
  /// <summary>
  /// Shape.
  /// </summary>
  Shape = unchecked((int)8),
  /// <summary>
  /// Enhanced metafile.
  /// </summary>
  EnhancedMetafile = unchecked((int)9),
  /// <summary>
  /// HTML. [System.Runtime.InteropServices.Guid("773B6CF3-4435-343F-BA19-8F0B7D78CC67")] public enum
  /// WdPasteDataType ﾉ Expand table
  /// </summary>
  HTML = unchecked((int)10)
}
