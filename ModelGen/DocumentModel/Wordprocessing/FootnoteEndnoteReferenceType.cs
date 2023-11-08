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
    get
    {
      return BooleanValueConverter.GetValue(_Element?.CustomMarkFollows);
    }
    set
    {
      _ExistingElement.CustomMarkFollows = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   Footnote/Endnote ID Reference
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
