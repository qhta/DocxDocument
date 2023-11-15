namespace DocumentModel.Math;


/// <summary>
///   Radical Function.
/// </summary>
public partial class Radical: ModelElement<DXM.Radical>
{
  public Radical(): base(){ }
  
  public Radical(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Radical(DXM.Radical openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Radical Properties.
  /// </summary>
  [DataMember]
  public DMM.RadicalProperties? RadicalProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Degree.
  /// </summary>
  [DataMember]
  public DMM.Degree? Degree
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OfficeMathArgumentType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OfficeMathArgumentType");
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
  
}
