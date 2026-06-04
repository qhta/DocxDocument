namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the format of the picture being copied.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlcopypictureformat?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("XlCopyPictureFormat")]
public enum XlCopyPictureFormat
{
  /// <summary>
  /// Bitmap (.bmp, .jpg, .gif).
  /// </summary>
  [WordInteropEnumValue("xlBitmap")]
  Bitmap = 2,
  /// <summary>
  /// Drawn picture (.png, .wmf, .mix).
  /// </summary>
  [WordInteropEnumValue("xlPicture")]
  Picture = -4147
}
