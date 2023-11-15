namespace DocumentModel.Drawings;


/// <summary>
///   Picture Bullet.
/// </summary>
public partial class PictureBullet: ModelElement<DXD.PictureBullet>
{
  public PictureBullet(): base(){ }
  
  public PictureBullet(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PictureBullet(DXD.PictureBullet openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Blip.
  /// </summary>
  [DataMember]
  public DMD.Blip? Blip
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
