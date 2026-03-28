namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the format for the Clipboard contents when they are inserted into a document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdpastedatatype?view=office-pia` for Office interop details.
/// </remarks>
public enum WdPasteDataType
{
  /// <summary>
  /// OLE object.
  /// </summary>
  OLEObject = 0,
  /// <summary>
  /// Rich Text Format (RTF).
  /// </summary>
  RTF = 1,
  /// <summary>
  /// Text.
  /// </summary>
  Text = 2,
  /// <summary>
  /// Metafile picture.
  /// </summary>
  MetafilePicture = 3,
  /// <summary>
  /// Bitmap.
  /// </summary>
  Bitmap = 4,
  /// <summary>
  /// Device-independent bitmap.
  /// </summary>
  DeviceIndependentBitmap = 5,
  /// <summary>
  /// Hyperlink.
  /// </summary>
  Hyperlink = 7,
  /// <summary>
  /// Shape.
  /// </summary>
  Shape = 8,
  /// <summary>
  /// Enhanced metafile.
  /// </summary>
  EnhancedMetafile = 9,
  /// <summary>
  /// HTML.
  /// </summary>
  HTML = 10
}
