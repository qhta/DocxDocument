namespace DocumentModel.Wordprocessing;


/// <summary>
///   Document-Wide Footnote Properties.
/// </summary>
public partial class FootnoteDocumentWideProperties: ModelElement<DXW.FootnoteDocumentWideProperties>
{
  public FootnoteDocumentWideProperties(): base(){ }
  
  public FootnoteDocumentWideProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FootnoteDocumentWideProperties(DXW.FootnoteDocumentWideProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Footnote Placement.
  /// </summary>
  [DataMember]
  public DMW.FootnotePositionKind? FootnotePosition
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   Footnote Numbering Format.
  /// </summary>
  [DataMember]
  public DMW.NumberingFormat? NumberingFormat
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   Footnote and Endnote Numbering Starting Value.
  /// </summary>
  [DataMember]
  public UInt16? NumberingStart
  {
    get => _Element?.GetIntVal<UInt16, DXW.NumberingStart>();
    set => _ExistingElement.SetIntVal<UInt16, DXW.NumberingStart>(value);
  }
  
  
  /// <summary>
  ///   Footnote and Endnote Numbering Restart Location.
  /// </summary>
  [DataMember]
  public DMW.RestartNumberKind? NumberingRestart
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
}
