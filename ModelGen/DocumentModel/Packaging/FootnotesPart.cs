namespace DocumentModel.Packaging;


/// <summary>
///   An instance of this part type contains all the footnotes for the document.
/// </summary>
public partial class FootnotesPart: ModelPartElement<DXPack.FootnotesPart>
{
  public FootnotesPart(): base(){ }
  
  public FootnotesPart(DXPack.OpenXmlPart openXmlElement): base(openXmlElement) { }
  
  public FootnotesPart(DXPack.FootnotesPart openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public String? ContentType
  {
    get
    {
      return _Element?.ContentType;
    }
    set
    {
      _ExistingElement.ContentType = value;
    }
  }
  
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  [DataMember]
  public DMW.Footnotes? Footnotes
  {
    get
    {
        return FootnotesConverter.CreateModelElement(_Element?.RootElement as DXW.Footnotes);
    }
    set
    {
      if (value != null)
      {
         var rootElement = FootnotesConverter.CreateOpenXmlElement<DXW.Footnotes>(value);
         if (rootElement != null)
           _ExistingElement.Footnotes = rootElement;
      }
    }
  }
  
  [DataMember]
  public String? RelationshipType
  {
    get
    {
      return _Element?.RelationshipType;
    }
    set
    {
      _ExistingElement.RelationshipType = value;
    }
  }
  
}
