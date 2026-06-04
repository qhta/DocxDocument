namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how the picture should be copied.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlpictureappearance?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("XlPictureAppearance")]
public enum XlPictureAppearance
{
  /// <summary>
  /// The picture is copied to resemble its display on the screen as closely as possible.
  /// </summary>
  [WordInteropEnumValue("xlScreen")]
  Screen = 1,
  /// <summary>
  /// The picture is copied as it will look when it is printed.
  /// </summary>
  [WordInteropEnumValue("xlPrinter")]
  Printer = 2
}
