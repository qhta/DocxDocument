namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of item to move the insertion point or selection just prior to.
/// </summary>
public enum WdGoToItem
{
  /// <summary>
  /// A section.
  /// </summary>
  Section = unchecked((int)0),
  /// <summary>
  /// A page.
  /// </summary>
  Page = unchecked((int)1),
  /// <summary>
  /// A table.
  /// </summary>
  Table = unchecked((int)2),
  /// <summary>
  /// A line.
  /// </summary>
  Line = unchecked((int)3),
  /// <summary>
  /// A footnote.
  /// </summary>
  Footnote = unchecked((int)4),
  /// <summary>
  /// An endnote.
  /// </summary>
  Endnote = unchecked((int)5),
  /// <summary>
  /// A comment.
  /// </summary>
  Comment = unchecked((int)6),
  /// <summary>
  /// A field.
  /// </summary>
  Field = unchecked((int)7),
  /// <summary>
  /// A graphic.
  /// </summary>
  Graphic = unchecked((int)8),
  /// <summary>
  /// An object. [System.Runtime.InteropServices.Guid("3568EE18-032C-39F9-A32B-179BC05CB782")] public enum
  /// WdGoToItem ﾉ Expand table
  /// </summary>
  Object = unchecked((int)9),
  /// <summary>
  /// An equation.
  /// </summary>
  Equation = unchecked((int)10),
  /// <summary>
  /// A heading.
  /// </summary>
  Heading = unchecked((int)11),
  /// <summary>
  /// A percent.
  /// </summary>
  Percent = unchecked((int)12),
  /// <summary>
  /// A spelling error.
  /// </summary>
  SpellingError = unchecked((int)13),
  /// <summary>
  /// A grammatical error.
  /// </summary>
  GrammaticalError = unchecked((int)14),
  /// <summary>
  /// A proofreading error.
  /// </summary>
  ProofreadingError = unchecked((int)15),
  /// <summary>
  /// Specifies the type of item to move the insertion point or selection just prior to.
  /// </summary>
  Bookmark = unchecked((int)-1)
}
