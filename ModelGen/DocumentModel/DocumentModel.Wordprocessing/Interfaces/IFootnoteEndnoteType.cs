namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FootnoteEndnoteType Class.
/// </summary>
public interface IFootnoteEndnoteType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Footnote/Endnote Type
  /// </summary>
  public FootnoteEndnoteKind? Type { get ; set; }
  
  /// <summary>
  /// Footnote/Endnote ID
  /// </summary>
  public Int32? Id { get ; set; }
  
}
