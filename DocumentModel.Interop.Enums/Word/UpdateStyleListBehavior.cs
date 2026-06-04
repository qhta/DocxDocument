namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the behavior Word 2010 should take when updating a style to match a selection that contains
/// numbering or bullets.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdupdatestylelistbehavior?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdUpdateStyleListBehavior")]
public enum UpdateStyleListBehavior
{
  /// <summary>
  /// Keeps the existing numbering or bullets pattern for all other paragraphs that use the same style and does not
  /// apply the numbering or bullets pattern of the selection.
  /// </summary>
  [WordInteropEnumValue("wdListBehaviorKeepPreviousPattern")]
  KeepPreviousPattern = 0,
  /// <summary>
  /// Adds the numbering or bullets pattern of the selection to all paragraphs in the document that use the same
  /// style.
  /// </summary>
  [WordInteropEnumValue("wdListBehaviorAddBulletsNumbering")]
  AddBulletsNumbering = 1
}
