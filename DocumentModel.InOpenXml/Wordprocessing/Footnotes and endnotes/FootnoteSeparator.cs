namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a specialized reference for a footnote separator in a WordprocessingML document.
/// This interface extends <see cref = "CollectionItem"/> and <see cref = "FootnoteEndnoteSeparatorReferenceType"/>, providing a property for the target footnote. Enables advanced management and referencing of footnote separators for visual separation and formatting of footnote content.
/// </summary>
public partial class FootnoteSeparator : FootnoteEndnoteSeparatorReferenceType
{
  /// <summary>
  /// Target footnote associated with this separator, specifying the footnote to which the separator applies.
  /// </summary>
  public Footnote? Footnote { get; set; }
}