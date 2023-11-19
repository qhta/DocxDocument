namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the FootnoteEndnoteType Class.
/// </summary>
public partial class FootnoteEndnoteType: ModelElement<DXW.FootnoteEndnoteType>
{
  public FootnoteEndnoteType(): base(){ }
  
  public FootnoteEndnoteType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FootnoteEndnoteType(DXW.FootnoteEndnoteType openXmlElement): base(openXmlElement) { }
  
  
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
