namespace DocumentModel.Math;


/// <summary>
///   Function Apply Function.
/// </summary>
public partial class MathFunction: ModelElement<DXM.MathFunction>
{
  public MathFunction(): base(){ }
  
  public MathFunction(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MathFunction(DXM.MathFunction openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Function Properties.
  /// </summary>
  [DataMember]
  public DMM.FunctionProperties? FunctionProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Function Name.
  /// </summary>
  [DataMember]
  public DMM.FunctionName? FunctionName
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OfficeMathArgumentType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OfficeMathArgumentType");
  }
  
  
  /// <summary>
  ///   Base (Argument).
  /// </summary>
  [DataMember]
  public DMM.Base? Base
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OfficeMathArgumentType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OfficeMathArgumentType");
  }
  
}
