namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how the picture should be copied.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlpictureappearance?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.XlPictureAppearance")]
public enum PictureAppearance
{
  /// <summary>
  /// The picture is copied to resemble its display on the screen as closely as possible.
  /// </summary>
  [InteropEnumValue("xlScreen")]
  Screen = 1,
  /// <summary>
  /// The picture is copied as it will look when it is printed.
  /// </summary>
  [InteropEnumValue("xlPrinter")]
  Printer = 2
}

