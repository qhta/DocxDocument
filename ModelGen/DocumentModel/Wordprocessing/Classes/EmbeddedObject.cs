namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that an embedded object is located at this position in the run’s contents. The layout properties of this embedded object, as well as an optional static representation, are specified using the drawing element.
/// </summary>
public partial class EmbeddedObject
{
  
  /// <summary>
  ///   dxaOrig
  /// </summary>
  [SchemaAttr("w:dxaOrig")]
  public String? DxaOriginal { get; set; }
  
  
  /// <summary>
  ///   dyaOrig
  /// </summary>
  [SchemaAttr("w:dyaOrig")]
  public String? DyaOriginal { get; set; }
  
  
  /// <summary>
  ///   anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w14:anchorId")]
  public DocumentModel.HexBinaryValue? AnchorId { get; set; }
  
  public DocumentModel.Wordprocessing.Drawing? Drawing { get; set; }
  
  public DocumentModel.Wordprocessing.Control? Control { get; set; }
  
  public DocumentModel.Wordprocessing.ObjectEmbed? ObjectEmbed { get; set; }
  
  public DocumentModel.Wordprocessing.ObjectLink? ObjectLink { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.IModelElement>? Items { get; set; }
  
}
