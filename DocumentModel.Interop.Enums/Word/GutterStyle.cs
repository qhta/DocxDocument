namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies where the gutter appears in the document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdgutterstyle?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdGutterStyle")]
public enum GutterStyle
{
  /// <summary>
  /// On the left side.
  /// </summary>
  [WordInteropEnumValue("wdGutterPosLeft")]
  Left = 0,
  /// <summary>
  /// At the top.
  /// </summary>
  [WordInteropEnumValue("wdGutterPosTop")]
  Top = 1,
  /// <summary>
  /// On the right side.
  /// </summary>
  [WordInteropEnumValue("wdGutterPosRight")]
  Right = 2
}
