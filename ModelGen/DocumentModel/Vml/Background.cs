namespace DocumentModel.Vml;


/// <summary>
///   Document Background.
/// </summary>
public partial class Background: ModelElement<DXV.Background>
{
  public Background(): base(){ }
  
  public Background(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Background(DXV.Background openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  [DataMember]
  public String? Id
  {
    get => _Element?.Id;
    set => _ExistingElement.Id = value;
  }
  
  
  /// <summary>
  ///   Shape Fill Toggle
  /// </summary>
  [DataMember]
  public Boolean? Filled
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Fill Color
  /// </summary>
  [DataMember]
  public String? Fillcolor
  {
    get => _Element?.Fillcolor;
    set => _ExistingElement.Fillcolor = value;
  }
  
  
  /// <summary>
  ///   Fill.
  /// </summary>
  [DataMember]
  public DMVML.Fill? Fill
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
