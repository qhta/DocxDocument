namespace DocumentModel.Math;


/// <summary>
///   Lower-Limit Function.
/// </summary>
public partial class LimitLower: ModelElement<DXM.LimitLower>
{
  public LimitLower(): base(){ }
  
  public LimitLower(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LimitLower(DXM.LimitLower openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Lower Limit Properties.
  /// </summary>
  [DataMember]
  public DMM.LimitLowerProperties? LimitLowerProperties
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
  ///   Limit (Lower).
  /// </summary>
  [DataMember]
  public DMM.Limit? Limit
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OfficeMathArgumentType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OfficeMathArgumentType");
  }
  
}
