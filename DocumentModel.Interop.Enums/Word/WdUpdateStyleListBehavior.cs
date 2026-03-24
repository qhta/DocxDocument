namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the behavior Word 2010 should take when updating a style to match a selection that contains
/// numbering or bullets.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdupdatestylelistbehavior?view=office-pia` for Office interop details.
/// </remarks>
public enum WdUpdateStyleListBehavior
{
  /// <summary>
  /// Specifies the behavior Word 2010 should take when updating a style to match a selection that contains
  /// numbering or bullets.
  /// </summary>
  KeepPreviousPattern = 0,
  /// <summary>
  /// Specifies the behavior Word 2010 should take when updating a style to match a selection that contains
  /// numbering or bullets.
  /// </summary>
  AddBulletsNumbering = 1
}
