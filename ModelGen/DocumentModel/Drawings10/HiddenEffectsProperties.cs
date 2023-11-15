namespace DocumentModel.Drawings10;


/// <summary>
///   Defines the HiddenEffectsProperties Class.
/// </summary>
public partial class HiddenEffectsProperties: ModelElement<DXO10D.HiddenEffectsProperties>
{
  public HiddenEffectsProperties(): base(){ }
  
  public HiddenEffectsProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public HiddenEffectsProperties(DXO10D.HiddenEffectsProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Effect Container.
  /// </summary>
  [DataMember]
  public DMD.EffectList? EffectList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Effect Container.
  /// </summary>
  [DataMember]
  public DMD.EffectDag? EffectDag
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.EffectContainerType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.EffectContainerType");
  }
  
}
