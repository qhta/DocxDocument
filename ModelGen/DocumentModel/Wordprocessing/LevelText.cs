namespace DocumentModel.Wordprocessing;


/// <summary>
///   Numbering Level Text.
/// </summary>
public partial class LevelText: ModelElement<DXW.LevelText>
{
  public LevelText(): base(){ }
  
  public LevelText(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LevelText(DXW.LevelText openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Level Text
  /// </summary>
  [DataMember]
  public String? Val
  {
    get => _Element?.Val;
    set => _ExistingElement.Val = value;
  }
  
  
  /// <summary>
  ///   Level Text Is Null Character
  /// </summary>
  [DataMember]
  public Boolean? Null
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
  }
  
}
