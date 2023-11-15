namespace DocumentModel.Wordprocessing;


/// <summary>
///   Legacy Numbering Level Properties.
/// </summary>
public partial class LegacyNumbering: ModelElement<DXW.LegacyNumbering>
{
  public LegacyNumbering(): base(){ }
  
  public LegacyNumbering(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LegacyNumbering(DXW.LegacyNumbering openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Use Legacy Numbering Properties
  /// </summary>
  [DataMember]
  public Boolean? Legacy
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
  }
  
  
  /// <summary>
  ///   Legacy Spacing
  /// </summary>
  [DataMember]
  public String? LegacySpace
  {
    get => _Element?.LegacySpace;
    set => _ExistingElement.LegacySpace = value;
  }
  
  
  /// <summary>
  ///   Legacy Indent
  /// </summary>
  [DataMember]
  public String? LegacyIndent
  {
    get => _Element?.LegacyIndent;
    set => _ExistingElement.LegacyIndent = value;
  }
  
}
