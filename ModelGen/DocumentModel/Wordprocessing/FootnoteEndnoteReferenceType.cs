namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the FootnoteEndnoteReferenceType Class.
/// </summary>
public partial class FootnoteEndnoteReferenceType: ModelElement<DXW.FootnoteEndnoteReferenceType>
{
  public FootnoteEndnoteReferenceType(): base(){ }
  
  public FootnoteEndnoteReferenceType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FootnoteEndnoteReferenceType(DXW.FootnoteEndnoteReferenceType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Suppress Footnote/Endnote Reference Mark
  /// </summary>
  [DataMember]
  public Boolean? CustomMarkFollows
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
  }
  
  
  /// <summary>
  ///   Footnote/Endnote ID Reference
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? Id
  {
    get => HexIntConverter.GetValue(_Element?.Id);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
}
