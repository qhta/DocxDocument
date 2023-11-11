namespace DocumentModel.Drawings10;


/// <summary>
///   Defines the ImageProperties Class.
/// </summary>
public partial class ImageProperties: ModelElement<DXO10D.ImageProperties>
{
  public ImageProperties(): base(){ }
  
  public ImageProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ImageProperties(DXO10D.ImageProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   ImageLayer.
  /// </summary>
  [DataMember]
  public DMD10.ImageLayer? ImageLayer
  {
    get
    {
      return _Element?.GetObject<DMD10.ImageLayer,DXO10D.ImageLayer>();
    }
    set
    {
      _ExistingElement.SetObject<DMD10.ImageLayer,DXO10D.ImageLayer>(value);
    }
  }
  
}
