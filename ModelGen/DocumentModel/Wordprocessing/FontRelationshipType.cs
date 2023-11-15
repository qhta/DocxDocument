namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the FontRelationshipType Class.
/// </summary>
public partial class FontRelationshipType: ModelElement<DXW.FontRelationshipType>
{
  public FontRelationshipType(): base(){ }
  
  public FontRelationshipType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FontRelationshipType(DXW.FontRelationshipType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   fontKey
  /// </summary>
  [DataMember]
  public String? FontKey
  {
    get => _Element?.FontKey;
    set => _ExistingElement.FontKey = value;
  }
  
  
  /// <summary>
  ///   subsetted
  /// </summary>
  [DataMember]
  public Boolean? Subsetted
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
  }
  
  
  /// <summary>
  ///   Relationship to Part
  /// </summary>
  [DataMember]
  public String? Id
  {
    get => _Element?.Id;
    set => _ExistingElement.Id = value;
  }
  
}
