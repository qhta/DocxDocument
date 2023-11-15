namespace DocumentModel.Math;


/// <summary>
///   Fraction Properties.
/// </summary>
public partial class FractionProperties: ModelElement<DXM.FractionProperties>
{
  public FractionProperties(): base(){ }
  
  public FractionProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FractionProperties(DXM.FractionProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Fraction type.
  /// </summary>
  [DataMember]
  public DMM.FractionTypeKind? FractionType
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
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
