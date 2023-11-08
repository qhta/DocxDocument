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
      var element = _Element?.GetFirstChild<DXO10D.ImageLayer>();
      if (element != null)
        return ImageLayerConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10D.ImageLayer>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ImageLayerConverter.CreateOpenXmlElement<DXO10D.ImageLayer>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
