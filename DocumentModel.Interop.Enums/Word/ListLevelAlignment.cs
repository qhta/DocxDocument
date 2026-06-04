namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the alignment of a list level.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdlistlevelalignment?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdListLevelAlignment")]
public enum ListLevelAlignment
{
  /// <summary>
  /// Left aligned.
  /// </summary>
  [WordInteropEnumValue("wdListLevelAlignLeft")]
  Left = 0,
  /// <summary>
  /// Center aligned.
  /// </summary>
  [WordInteropEnumValue("wdListLevelAlignCenter")]
  Center = 1,
  /// <summary>
  /// Right aligned.
  /// </summary>
  [WordInteropEnumValue("wdListLevelAlignRight")]
  Right = 2
}
