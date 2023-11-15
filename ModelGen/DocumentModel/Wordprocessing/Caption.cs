namespace DocumentModel.Wordprocessing;


/// <summary>
///   Single Caption Type Definition.
/// </summary>
public partial class Caption: ModelElement<DXW.Caption>
{
  public Caption(): base(){ }
  
  public Caption(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Caption(DXW.Caption openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Caption Type Name
  /// </summary>
  [DataMember]
  public String? Name
  {
    get => _Element?.Name;
    set => _ExistingElement.Name = value;
  }
  
  
  /// <summary>
  ///   Include Chapter Number in Field for Caption
  /// </summary>
  [DataMember]
  public Boolean? ChapterNumber
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
  }
  
  
  /// <summary>
  ///   Style for Chapter Headings
  /// </summary>
  [DataMember]
  public Int32? Heading
  {
    get => _Element?.Heading?.Value;
    set => _ExistingElement.Heading = value;
  }
  
  
  /// <summary>
  ///   Do Not Include Name In Caption
  /// </summary>
  [DataMember]
  public Boolean? NoLabel
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
  }
  
}
