namespace DocumentModel.Math;


/// <summary>
///   Radical Properties.
/// </summary>
public partial class RadicalProperties: ModelElement<DXM.RadicalProperties>
{
  public RadicalProperties(): base(){ }
  
  public RadicalProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RadicalProperties(DXM.RadicalProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Hide Degree.
  /// </summary>
  [DataMember]
  public DMM.HideDegree? HideDegree
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OnOffType");
  }
  
  
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
