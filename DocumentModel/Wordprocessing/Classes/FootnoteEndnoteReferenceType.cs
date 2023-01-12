namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FootnoteEndnoteReferenceType Class.
/// </summary>
public partial class FootnoteEndnoteReferenceType
{
  /// <summary>
  /// Suppress Footnote/Endnote Reference Mark
  /// </summary>
  public Boolean? CustomMarkFollows { get; set; }
  
  /// <summary>
  /// Footnote/Endnote ID Reference
  /// </summary>
  public Int64? Id { get; set; }
  
}
