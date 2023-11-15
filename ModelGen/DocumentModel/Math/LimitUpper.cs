namespace DocumentModel.Math;


/// <summary>
///   Upper-Limit Function.
/// </summary>
public partial class LimitUpper: ModelElement<DXM.LimitUpper>
{
  public LimitUpper(): base(){ }
  
  public LimitUpper(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LimitUpper(DXM.LimitUpper openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Upper Limit Properties.
  /// </summary>
  [DataMember]
  public DMM.LimitUpperProperties? LimitUpperProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Base.
  /// </summary>
  [DataMember]
  public DMM.Base? Base
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OfficeMathArgumentType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OfficeMathArgumentType");
  }
  
  
  /// <summary>
  ///   Limit (Upper).
  /// </summary>
  [DataMember]
  public DMM.Limit? Limit
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OfficeMathArgumentType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OfficeMathArgumentType");
  }
  
}
