namespace DocumentModel.Math;


/// <summary>
///   Border-Box Function.
/// </summary>
public partial class BorderBox: ModelElement<DXM.BorderBox>
{
  public BorderBox(): base(){ }
  
  public BorderBox(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BorderBox(DXM.BorderBox openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Border Box Properties.
  /// </summary>
  [DataMember]
  public DMM.BorderBoxProperties? BorderBoxProperties
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
