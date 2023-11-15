namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a blend of several effects. The container specifies the raw effects to blend while the blend mode specifies how the effects are to be blended.
/// </summary>
public partial class Blend: ModelElement<DXD.Blend>
{
  public Blend(): base(){ }
  
  public Blend(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Blend(DXD.Blend openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Effect to blend.
  /// </summary>
  [DataMember]
  public DMD.EffectContainer? EffectContainer
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.EffectContainerType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.EffectContainerType");
  }
  
}
