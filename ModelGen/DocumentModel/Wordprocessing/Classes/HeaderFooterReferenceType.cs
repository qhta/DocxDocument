namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the HeaderFooterReferenceType Class.
/// </summary>
public partial class HeaderFooterReferenceType
{
  
  /// <summary>
  ///   type
  /// </summary>
  [SchemaAttr("w:type")]
  public DocumentModel.Wordprocessing.HeaderFooterValues? Type { get; set; }
  
  
  /// <summary>
  ///   Relationship to Part
  /// </summary>
  [SchemaAttr("r:id")]
  public String? Id { get; set; }
  
}
