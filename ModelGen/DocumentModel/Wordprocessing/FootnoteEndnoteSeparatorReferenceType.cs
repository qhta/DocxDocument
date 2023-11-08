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
  public Int64? Id
  {
    get
    {
      return _Element?.Id?.Value;
    }
    set
    {
      _ExistingElement.Id = value;
    }
  }
  
}
