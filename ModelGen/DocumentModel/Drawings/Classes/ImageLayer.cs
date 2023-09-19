namespace DocumentModel.Drawings;


/// <summary>
///   Defines the ImageLayer Class.
/// </summary>
public partial class ImageLayer
{
  
  /// <summary>
  ///   embed, this property is only available in Office 2010 and later.
  /// </summary>
  [Nullable((Byte)2)]
  [SchemaAttr("r:embed")]
  public String? Embed { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.Drawings.ImageEffect>? Items { get; set; }
  
}
