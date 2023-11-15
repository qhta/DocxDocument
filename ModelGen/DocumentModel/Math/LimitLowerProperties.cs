namespace DocumentModel.Math;


/// <summary>
///   Lower Limit Properties.
/// </summary>
public partial class LimitLowerProperties: ModelElement<DXM.LimitLowerProperties>
{
  public LimitLowerProperties(): base(){ }
  
  public LimitLowerProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LimitLowerProperties(DXM.LimitLowerProperties openXmlElement): base(openXmlElement) { }
  
  
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
