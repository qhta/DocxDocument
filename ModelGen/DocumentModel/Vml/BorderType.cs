namespace DocumentModel.Vml;


/// <summary>
///   Defines the BorderType Class.
/// </summary>
public partial class BorderType: ModelElement<DXVW.BorderType>
{
  public BorderType(): base(){ }
  
  public BorderType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BorderType(DXVW.BorderType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Border Width
  /// </summary>
  [DataMember]
  public Int64? Width
  {
    get => _Element?.Width?.Value;
    set => _ExistingElement.Width = value;
  }
  
  
  /// <summary>
  ///   Border shadow
  /// </summary>
  [DataMember]
  public Boolean? Shadow
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
}
