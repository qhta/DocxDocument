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
