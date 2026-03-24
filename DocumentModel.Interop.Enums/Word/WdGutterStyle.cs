namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies where the gutter appears in the document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdgutterstyle?view=office-pia` for Office interop details.
/// </remarks>
public enum WdGutterStyle
{
  /// <summary>
  /// On the left side.
  /// </summary>
  Left = 0,
  /// <summary>
  /// At the top.
  /// </summary>
  Top = 1,
  /// <summary>
  /// On the right side.
  /// </summary>
  Right = 2
}
