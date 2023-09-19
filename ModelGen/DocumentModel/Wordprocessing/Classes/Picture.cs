namespace DocumentModel.Wordprocessing;


/// <summary>
///   VML Object.
/// </summary>
public partial class Picture
{
  
  /// <summary>
  ///   anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  [Nullable((Byte)2)]
  [SchemaAttr("w14:anchorId")]
  public DocumentModel.HexBinaryValue? AnchorId { get; set; }
  
  public DocumentModel.Wordprocessing.RelationshipType? MovieReference { get; set; }
  
  public DocumentModel.Wordprocessing.Control? Control { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.IModelElement>? Items { get; set; }
  
}
