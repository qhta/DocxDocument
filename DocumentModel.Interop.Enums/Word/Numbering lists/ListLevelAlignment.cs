namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the alignment of a list level.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdlistlevelalignment?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdListLevelAlignment")]
public enum ListLevelAlignment
{
  /// <summary>
  /// Left aligned.
  /// </summary>
  [InteropEnumValue("wdListLevelAlignLeft")]
  Left = 0,
  /// <summary>
  /// Center aligned.
  /// </summary>
  [InteropEnumValue("wdListLevelAlignCenter")]
  Center = 1,
  /// <summary>
  /// Right aligned.
  /// </summary>
  [InteropEnumValue("wdListLevelAlignRight")]
  Right = 2
}
