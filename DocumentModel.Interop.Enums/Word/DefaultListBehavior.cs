namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the default list behavior for a list.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wddefaultlistbehavior?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdDefaultListBehavior")]
public enum DefaultListBehavior
{
  /// <summary>
  /// Use formatting compatible with Microsoft Word 97.
  /// </summary>
  [WordInteropEnumValue("wdWord8ListBehavior")]
  Word8 = 0,
  /// <summary>
  /// Use Web-oriented formatting as introduced in Microsoft Word 2000.
  /// </summary>
  [WordInteropEnumValue("wdWord9ListBehavior")]
  Word9 = 1,
  /// <summary>
  /// Use formatting compatible with Microsoft Word 2002.
  /// </summary>
  [WordInteropEnumValue("wdWord10ListBehavior")]
  Word10 = 2
}
