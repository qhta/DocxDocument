namespace DocumentModel.Drawings.Diagram1;


/// <summary>
///   Defines the DiagramAutoBullet Class.
/// </summary>
public partial class DiagramAutoBullet: ModelElement<DXO19DD11.DiagramAutoBullet>
{
  public DiagramAutoBullet(): base(){ }
  
  public DiagramAutoBullet(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DiagramAutoBullet(DXO19DD11.DiagramAutoBullet openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   prefix, this property is only available in Office 2019 and later.
  /// </summary>
  [DataMember]
  public String? AutoBulletPrefix
  {
    get => _Element?.AutoBulletPrefix;
    set => _ExistingElement.AutoBulletPrefix = value;
  }
  
  
  /// <summary>
  ///   leadZeros, this property is only available in Office 2019 and later.
  /// </summary>
  [DataMember]
  public Boolean? LeadZeros
  {
    get => _Element?.LeadZeros?.Value;
    set => _ExistingElement.LeadZeros = value;
  }
  
  
  /// <summary>
  ///   No Bullet.
  /// </summary>
  [DataMember]
  public DMD.NoBullet? NoBullet
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   Auto-Numbered Bullet.
  /// </summary>
  [DataMember]
  public DMD.AutoNumberedBullet? AutoNumberedBullet
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   Character Bullet.
  /// </summary>
  [DataMember]
  public DMD.CharacterBullet? CharacterBullet
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   Picture Bullet.
  /// </summary>
  [DataMember]
  public DMD.PictureBullet? PictureBullet
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
