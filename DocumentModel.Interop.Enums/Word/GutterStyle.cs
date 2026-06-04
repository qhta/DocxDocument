namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies where the gutter appears in the document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdgutterstyle?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdGutterStyle")]
public enum GutterStyle
{
  /// <summary>
  /// On the left side.
  /// </summary>
  [InteropEnumValue("wdGutterPosLeft")]
  Left = 0,
  /// <summary>
  /// At the top.
  /// </summary>
  [InteropEnumValue("wdGutterPosTop")]
  Top = 1,
  /// <summary>
  /// On the right side.
  /// </summary>
  [InteropEnumValue("wdGutterPosRight")]
  Right = 2
}
