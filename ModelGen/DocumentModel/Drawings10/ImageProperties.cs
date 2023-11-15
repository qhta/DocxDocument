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
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
