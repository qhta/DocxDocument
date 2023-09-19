namespace DocumentModel.Drawings;


/// <summary>
///   Defines the ImageProperties Class.
/// </summary>
public partial class ImageProperties
{
  
  /// <summary>
  ///   ImageLayer.
  /// </summary>
  [Nullable((Byte)2)]
  public DocumentModel.Drawings.ImageLayer? ImageLayer { get; set; }
  
}
