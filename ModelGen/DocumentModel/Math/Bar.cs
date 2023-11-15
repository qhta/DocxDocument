namespace DocumentModel.Math;


/// <summary>
///   Bar.
/// </summary>
public partial class Bar: ModelElement<DXM.Bar>
{
  public Bar(): base(){ }
  
  public Bar(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Bar(DXM.Bar openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Bar Properties.
  /// </summary>
  [DataMember]
  public DMM.BarProperties? BarProperties
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
  
}
