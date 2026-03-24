namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of item to move the insertion point or selection just prior to.
/// </summary>
public enum WdGoToItem
{
  /// <summary>
  /// A section.
  /// </summary>
  Section = 0,
  /// <summary>
  /// A page.
  /// </summary>
  Page = 1,
  /// <summary>
  /// A table.
  /// </summary>
  Table = 2,
  /// <summary>
  /// A line.
  /// </summary>
  Line = 3,
  /// <summary>
  /// A footnote.
  /// </summary>
  Footnote = 4,
  /// <summary>
  /// An endnote.
  /// </summary>
  Endnote = 5,
  /// <summary>
  /// A comment.
  /// </summary>
  Comment = 6,
  /// <summary>
  /// A field.
  /// </summary>
  Field = 7,
  /// <summary>
  /// A graphic.
  /// </summary>
  Graphic = 8,
  /// <summary>
  /// An object. [System.Runtime.InteropServices.Guid("3568EE18-032C-39F9-A32B-179BC05CB782")] public enum
  /// WdGoToItem ﾉ Expand table
  /// </summary>
  Object = 9,
  /// <summary>
  /// An equation.
  /// </summary>
  Equation = 10,
  /// <summary>
  /// A heading.
  /// </summary>
  Heading = 11,
  /// <summary>
  /// A percent.
  /// </summary>
  Percent = 12,
  /// <summary>
  /// A spelling error.
  /// </summary>
  SpellingError = 13,
  /// <summary>
  /// A grammatical error.
  /// </summary>
  GrammaticalError = 14,
  /// <summary>
  /// A proofreading error.
  /// </summary>
  ProofreadingError = 15,
  /// <summary>
  /// Specifies the type of item to move the insertion point or selection just prior to.
  /// </summary>
  Bookmark = -1
}
