namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies where the gutter appears in the document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdgutterstyle?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdGutterStyle))]
public enum GutterStyle
{
  /// <summary>
  /// On the left side.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdGutterStyle.wdGutterPosLeft))]
  Left = 0,
  /// <summary>
  /// At the top.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdGutterStyle.wdGutterPosTop))]
  Top = 1,
  /// <summary>
  /// On the right side.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdGutterStyle.wdGutterPosRight))]
  Right = 2
}
