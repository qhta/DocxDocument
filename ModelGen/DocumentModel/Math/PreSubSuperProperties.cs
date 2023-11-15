namespace DocumentModel.Math;


/// <summary>
///   Pre-Sub-Superscript Properties.
/// </summary>
public partial class PreSubSuperProperties: ModelElement<DXM.PreSubSuperProperties>
{
  public PreSubSuperProperties(): base(){ }
  
  public PreSubSuperProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PreSubSuperProperties(DXM.PreSubSuperProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   ControlProperties.
  /// </summary>
  [DataMember]
  public DMM.ControlProperties? ControlProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
