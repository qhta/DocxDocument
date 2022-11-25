namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FootnoteEndnoteType Class.
/// </summary>
public interface IFootnoteEndnoteType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Footnote/Endnote Type
  /// </summary>
  public DocumentModel.Wordprocessing.FootnoteEndnoteKind? Type { get ; set; }
  
  /// <summary>
  /// Footnote/Endnote ID
  /// </summary>
  public System.Int32? Id { get ; set; }
  
}
