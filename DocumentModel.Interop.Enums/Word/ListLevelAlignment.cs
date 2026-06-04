namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the alignment of a list level.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdlistlevelalignment?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdListLevelAlignment))]
public enum ListLevelAlignment
{
  /// <summary>
  /// Left aligned.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListLevelAlignment.wdListLevelAlignLeft))]
  Left = 0,
  /// <summary>
  /// Center aligned.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListLevelAlignment.wdListLevelAlignCenter))]
  Center = 1,
  /// <summary>
  /// Right aligned.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListLevelAlignment.wdListLevelAlignRight))]
  Right = 2
}
