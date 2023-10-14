namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the existence of an image (binary large image or picture) and contains a reference to the image data.
/// </summary>
public partial class Blip
{
  
  /// <summary>
  ///   Embedded Picture Reference
  /// </summary>
  public String? Embed { get; set; }
  
  
  /// <summary>
  ///   Linked Picture Reference
  /// </summary>
  public String? Link { get; set; }
  
  
  /// <summary>
  ///   Compression state for blips.
  /// </summary>
  public DocumentModel.Drawings.BlipCompressionKind? CompressionState { get; set; }
  
  public DocumentModel.Drawings.BlipExtensionList? BlipExtensionList { get; set; }
  
  public DM.ElementCollection<IModelElement>? Items { get; set; }
  
}
