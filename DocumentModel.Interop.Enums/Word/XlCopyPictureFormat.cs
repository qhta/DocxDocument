namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the format of the picture being copied.
/// </summary>
public enum XlCopyPictureFormat
{
  /// <summary>
  /// Bitmap (.bmp, .jpg, .gif).
  /// </summary>
  Bitmap = unchecked((int)2),
  /// <summary>
  /// Specifies the format of the picture being copied.
  /// </summary>
  Picture = unchecked((int)-4147)
}
