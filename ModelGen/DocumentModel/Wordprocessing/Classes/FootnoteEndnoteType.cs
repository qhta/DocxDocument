namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the FootnoteEndnoteType Class.
/// </summary>
public partial class FootnoteEndnoteType
{
  
  /// <summary>
  ///   Footnote/Endnote Type
  /// </summary>
  [SchemaAttr("w:type")]
  public DocumentModel.Wordprocessing.FootnoteEndnoteValues? Type { get; set; }
  
  
  /// <summary>
  ///   Footnote/Endnote ID
  /// </summary>
  [SchemaAttr("w:id")]
  public Int64? Id { get; set; }
  
}
