namespace DocumentModel.Wordprocessing;


/// <summary>
///   Picture Numbering Symbol Definition.
/// </summary>
public partial class NumberingPictureBullet: ModelElement<DXW.NumberingPictureBullet>
{
  public NumberingPictureBullet(): base(){ }
  
  public NumberingPictureBullet(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NumberingPictureBullet(DXW.NumberingPictureBullet openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   numPicBulletId
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? NumberingPictureBulletId
  {
    get => HexIntConverter.GetValue(_Element?.NumberingPictureBulletId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   PictureBulletBase.
  /// </summary>
  [DataMember]
  public DMW.PictureBulletBase? PictureBulletBase
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Drawing.
  /// </summary>
  [DataMember]
  public DMW.Drawing? Drawing
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
