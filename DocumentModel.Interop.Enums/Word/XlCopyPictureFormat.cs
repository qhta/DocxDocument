namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the format of the picture being copied.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlcopypictureformat?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.XlCopyPictureFormat))]
public enum XlCopyPictureFormat
{
  /// <summary>
  /// Bitmap (.bmp, .jpg, .gif).
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlCopyPictureFormat.xlBitmap))]
  Bitmap = 2,
  /// <summary>
  /// Drawn picture (.png, .wmf, .mix).
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlCopyPictureFormat.xlPicture))]
  Picture = -4147
}
