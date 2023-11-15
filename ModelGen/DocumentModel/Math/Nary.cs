namespace DocumentModel.Math;


/// <summary>
///   n-ary Operator Function.
/// </summary>
public partial class Nary: ModelElement<DXM.Nary>
{
  public Nary(): base(){ }
  
  public Nary(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Nary(DXM.Nary openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   n-ary Properties.
  /// </summary>
  [DataMember]
  public DMM.NaryProperties? NaryProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Lower limit (n-ary) .
  /// </summary>
  [DataMember]
  public DMM.SubArgument? SubArgument
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OfficeMathArgumentType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OfficeMathArgumentType");
  }
  
  
  /// <summary>
  ///   Upper limit (n-ary).
  /// </summary>
  [DataMember]
  public DMM.SuperArgument? SuperArgument
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
