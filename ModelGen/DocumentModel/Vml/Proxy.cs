namespace DocumentModel.Vml;


/// <summary>
///   Shape Reference.
/// </summary>
public partial class Proxy: ModelElement<DXVO.Proxy>
{
  public Proxy(): base(){ }
  
  public Proxy(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Proxy(DXVO.Proxy openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Start Point Connection Flag
  /// </summary>
  [DataMember]
  public Boolean? Start
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseBlankValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseBlankValue");
  }
  
  
  /// <summary>
  ///   End Point Connection Flag
  /// </summary>
  [DataMember]
  public Boolean? End
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseBlankValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseBlankValue");
  }
  
  
  /// <summary>
  ///   Proxy Shape Reference
  /// </summary>
  [DataMember]
  public String? ShapeReference
  {
    get => _Element?.ShapeReference;
    set => _ExistingElement.ShapeReference = value;
  }
  
  
  /// <summary>
  ///   Connection Location
  /// </summary>
  [DataMember]
  public Int32? ConnectionLocation
  {
    get => _Element?.ConnectionLocation?.Value;
    set => _ExistingElement.ConnectionLocation = value;
  }
  
}
