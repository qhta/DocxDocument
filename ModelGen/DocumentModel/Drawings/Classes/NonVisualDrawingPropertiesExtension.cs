namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies an extension that is used for future extensions to the current version of DrawingML. This allows for the specifying of currently unknown elements in the future that is used for later versions of generating applications.
/// </summary>
public partial class NonVisualDrawingPropertiesExtension
{
  
  /// <summary>
  ///   Specifies the URI, or uniform resource identifier that represents the data stored under this tag. The URI is used to identify the correct 'server' that can process the contents of this tag.
  /// </summary>
  [Nullable((Byte)2)]
  [SchemaAttr("uri")]
  public String? Uri { get; set; }
  
  public DocumentModel.Drawings.CompatExtension? CompatExtension { get; set; }
  
  public DocumentModel.Drawings.BackgroundProperties? BackgroundProperties { get; set; }
  
  public DocumentModel.Drawings.CreationId? CreationId { get; set; }
  
  public DocumentModel.Drawings.PredecessorDrawingElementReference? PredecessorDrawingElementReference { get; set; }
  
  public Boolean? Decorative { get; set; }
  
  public DocumentModel.Drawings.ClassificationOutcome? ClassificationOutcome { get; set; }
  
  public DocumentModel.Drawings.Office.ScriptLink.ScriptLink? ScriptLink { get; set; }
  
}
