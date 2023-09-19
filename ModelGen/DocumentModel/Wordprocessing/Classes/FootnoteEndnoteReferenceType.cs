namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the FootnoteEndnoteReferenceType Class.
/// </summary>
public partial class FootnoteEndnoteReferenceType
{
  
  /// <summary>
  ///   Suppress Footnote/Endnote Reference Mark
  /// </summary>
  [SchemaAttr("w:customMarkFollows")]
  public Boolean? CustomMarkFollows { get; set; }
  
  
  /// <summary>
  ///   Footnote/Endnote ID Reference
  /// </summary>
  [SchemaAttr("w:id")]
  public Int64? Id { get; set; }
  
}
