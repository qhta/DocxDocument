namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how the picture should be copied.
/// </summary>
public enum XlPictureAppearance
{
  /// <summary>
  /// The picture is copied to resemble its display on the screen as closely as possible.
  /// </summary>
  Screen = unchecked((int)1),
  /// <summary>
  /// The picture is copied as it will look when it is printed.
  /// </summary>
  Printer = unchecked((int)2)
}
