namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a reference type for footnote or endnote separator elements in a WordprocessingML document.
///   This interface provides a property for the footnote or endnote ID, enabling advanced management and referencing of separator elements for visual separation and formatting of footnote and endnote content.
/// </summary>
public class FootnoteEndnoteSeparatorReferenceType: CollectionItem
{
  /// <summary>
  ///   Identifier for the footnote or endnote associated with this separator reference.
  /// </summary>
  public Int32? Id { get; set; }
}