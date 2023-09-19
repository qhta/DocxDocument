namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the existence of an image (binary large image or picture) and contains a reference to the image data.
/// </summary>
public partial class Blip
{
  
  /// <summary>
  ///   Embedded Picture Reference
  /// </summary>
  [SchemaAttr("r:embed")]
  public String? Embed { get; set; }
  
  
  /// <summary>
  ///   Linked Picture Reference
  /// </summary>
  [SchemaAttr("r:link")]
  public String? Link { get; set; }
  
  
  /// <summary>
  ///   Compression state for blips.
  /// </summary>
  [SchemaAttr("cstate")]
  public DocumentModel.Drawings.BlipCompressionValues? CompressionState { get; set; }
  
  public DocumentModel.Drawings.BlipExtensionList? BlipExtensionList { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.IModelElement>? Items { get; set; }
  
}
