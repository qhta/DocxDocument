namespace DocumentModel.Math;


/// <summary>
///   Upper Limit Properties.
/// </summary>
public partial class LimitUpperProperties: ModelElement<DXM.LimitUpperProperties>
{
  public LimitUpperProperties(): base(){ }
  
  public LimitUpperProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LimitUpperProperties(DXM.LimitUpperProperties openXmlElement): base(openXmlElement) { }
  
  
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
