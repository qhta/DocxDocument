namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies any East Asian typography settings which shall be applied to the contents of the run.
/// </summary>
public partial class EastAsianLayout: ModelElement<DXW.EastAsianLayout>
{
  public EastAsianLayout(): base(){ }
  
  public EastAsianLayout(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public EastAsianLayout(DXW.EastAsianLayout openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   East Asian Typography Run ID
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? Id
  {
    get => HexIntConverter.GetValue(_Element?.Id);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Two Lines in One
  /// </summary>
  [DataMember]
  public Boolean? Combine
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
  }
  
  
  /// <summary>
  ///   Horizontal in Vertical (Rotate Text)
  /// </summary>
  [DataMember]
  public Boolean? Vertical
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
  }
  
  
  /// <summary>
  ///   Compress Rotated Text to Line Height
  /// </summary>
  [DataMember]
  public Boolean? VerticalCompress
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
  }
  
}
