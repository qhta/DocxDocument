namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the FootnoteEndnoteSeparatorReferenceType Class.
/// </summary>
public interface FootnoteEndnoteSeparatorReferenceType: IModelElement
{
  /// <summary>
  ///   Footnote/Endnote ID
  /// </summary>
  public Int32? Id { get; set; }
}