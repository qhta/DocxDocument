namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the FootnoteEndnoteSeparatorReferenceType Class.
/// </summary>
public partial class FootnoteEndnoteSeparatorReferenceType: ModelElement<DXW.FootnoteEndnoteSeparatorReferenceType>
{
  public FootnoteEndnoteSeparatorReferenceType(): base(){ }
  
  public FootnoteEndnoteSeparatorReferenceType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FootnoteEndnoteSeparatorReferenceType(DXW.FootnoteEndnoteSeparatorReferenceType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Footnote/Endnote ID
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? Id
  {
    get => HexIntConverter.GetValue(_Element?.Id);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
}
