namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FootnoteEndnoteType Class.
/// </summary>
public partial class FootnoteEndnoteType
{
  /// <summary>
  /// Footnote/Endnote Type
  /// </summary>
  public DocumentModel.Wordprocessing.FootnoteEndnoteKind? Type { get; set; }
  
  /// <summary>
  /// Footnote/Endnote ID
  /// </summary>
  public Int64? Id { get; set; }
  
}
