namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the format of the picture being copied.
/// </summary>
public enum XlCopyPictureFormat
{
  /// <summary>
  /// Bitmap (.bmp, .jpg, .gif).
  /// </summary>
  xlBitmap = unchecked((int)2),
  /// <summary>
  /// Specifies the format of the picture being copied.
  /// </summary>
  xlPicture = unchecked((int)-4147)
}
