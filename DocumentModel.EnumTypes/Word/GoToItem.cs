namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of item to move the insertion point or selection just prior to.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdgotoitem?view=office-pia` for Office interop details.
/// </remarks>
public enum GoToItem
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
  /// An object.
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
  /// A bookmark.
  /// </summary>
  Bookmark = -1
}
