namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FootnoteEndnoteReferenceType Class.
/// </summary>
public interface IFootnoteEndnoteReferenceType // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Suppress Footnote/Endnote Reference Mark
  /// </summary>
  public System.Boolean? CustomMarkFollows { get ; set; }
  
  /// <summary>
  /// Footnote/Endnote ID Reference
  /// </summary>
  public System.Int32? Id { get ; set; }
  
}
