namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a more or less opaque version of its input color. An alpha modulate never increases the alpha beyond 100%. A 200% alpha modulate makes an input color twice as opaque as before. A 50% alpha modulate makes an input color half as opaque as before.
/// </summary>
public partial class AlphaModulationEffect: ModelElement<DXD.AlphaModulationEffect>
{
  public AlphaModulationEffect(): base(){ }
  
  public AlphaModulationEffect(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AlphaModulationEffect(DXD.AlphaModulationEffect openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   EffectContainer.
  /// </summary>
  [DataMember]
  public DMD.EffectContainer? EffectContainer
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.EffectContainerType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.EffectContainerType");
  }
  
}
