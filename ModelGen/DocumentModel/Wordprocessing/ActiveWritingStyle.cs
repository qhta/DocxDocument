namespace DocumentModel.Wordprocessing;


/// <summary>
///   Grammar Checking Settings.
/// </summary>
public partial class ActiveWritingStyle: ModelElement<DXW.ActiveWritingStyle>
{
  public ActiveWritingStyle(): base(){ }
  
  public ActiveWritingStyle(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ActiveWritingStyle(DXW.ActiveWritingStyle openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Writing Style Language
  /// </summary>
  [DataMember]
  public String? Language
  {
    get => _Element?.Language;
    set => _ExistingElement.Language = value;
  }
  
  
  /// <summary>
  ///   Grammatical Engine ID
  /// </summary>
  [DataMember]
  public UInt16? VendorID
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt16]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt16]");
  }
  
  
  /// <summary>
  ///   Grammatical Check Engine Version
  /// </summary>
  [DataMember]
  public Int32? DllVersion
  {
    get => _Element?.DllVersion?.Value;
    set => _ExistingElement.DllVersion = value;
  }
  
  
  /// <summary>
  ///   Natural Language Grammar Check
  /// </summary>
  [DataMember]
  public Boolean? NaturalLanguageGrammarCheck
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
  }
  
  
  /// <summary>
  ///   Check Stylistic Rules With Grammar
  /// </summary>
  [DataMember]
  public Boolean? CheckStyle
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
  }
  
  
  /// <summary>
  ///   Application Name
  /// </summary>
  [DataMember]
  public String? ApplicationName
  {
    get => _Element?.ApplicationName;
    set => _ExistingElement.ApplicationName = value;
  }
  
}
