namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of item to move the insertion point or selection just prior to.
/// </summary>
public enum WdGoToItem
{
  /// <summary>
  /// A section.
  /// </summary>
  wdGoToSection = unchecked((int)0),
  /// <summary>
  /// A page.
  /// </summary>
  wdGoToPage = unchecked((int)1),
  /// <summary>
  /// A table.
  /// </summary>
  wdGoToTable = unchecked((int)2),
  /// <summary>
  /// A line.
  /// </summary>
  wdGoToLine = unchecked((int)3),
  /// <summary>
  /// A footnote.
  /// </summary>
  wdGoToFootnote = unchecked((int)4),
  /// <summary>
  /// An endnote.
  /// </summary>
  wdGoToEndnote = unchecked((int)5),
  /// <summary>
  /// A comment.
  /// </summary>
  wdGoToComment = unchecked((int)6),
  /// <summary>
  /// A field.
  /// </summary>
  wdGoToField = unchecked((int)7),
  /// <summary>
  /// A graphic.
  /// </summary>
  wdGoToGraphic = unchecked((int)8),
  /// <summary>
  /// An object. [System.Runtime.InteropServices.Guid("3568EE18-032C-39F9-A32B-179BC05CB782")] public enum
  /// WdGoToItem ﾉ Expand table
  /// </summary>
  wdGoToObject = unchecked((int)9),
  /// <summary>
  /// An equation.
  /// </summary>
  wdGoToEquation = unchecked((int)10),
  /// <summary>
  /// A heading.
  /// </summary>
  wdGoToHeading = unchecked((int)11),
  /// <summary>
  /// A percent.
  /// </summary>
  wdGoToPercent = unchecked((int)12),
  /// <summary>
  /// A spelling error.
  /// </summary>
  wdGoToSpellingError = unchecked((int)13),
  /// <summary>
  /// A grammatical error.
  /// </summary>
  wdGoToGrammaticalError = unchecked((int)14),
  /// <summary>
  /// A proofreading error.
  /// </summary>
  wdGoToProofreadingError = unchecked((int)15),
  /// <summary>
  /// Specifies the type of item to move the insertion point or selection just prior to.
  /// </summary>
  wdGoToBookmark = unchecked((int)-1)
}
