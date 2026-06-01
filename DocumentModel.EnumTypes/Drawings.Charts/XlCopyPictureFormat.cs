namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the format of the picture being copied.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlcopypictureformat?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum XlCopyPictureFormat
{
  /// <summary>
  /// Bitmap (.bmp, .jpg, .gif).
  /// </summary>
  Bitmap = 2,
  /// <summary>
  /// Drawn picture (.png, .wmf, .mix).
  /// </summary>
  Picture = -4147
}

