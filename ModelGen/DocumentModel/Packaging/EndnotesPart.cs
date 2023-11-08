namespace DocumentModel.Packaging;


/// <summary>
///   An instance of this part type contains all the endnotes for the document.
/// </summary>
public partial class EndnotesPart: ModelElement<DXPack.EndnotesPart>
{
  public EndnotesPart(): base(){ }
  
  public EndnotesPart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public EndnotesPart(DXPack.EndnotesPart openXmlElement): base(openXmlElement) { }
  
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
  public DMW.Endnotes? Endnotes
  {
    get
    {
        return EndnotesConverter.CreateModelElement(_Element?.RootElement as DXW.Endnotes);
    }
    set
    {
      if (value != null)
      {
         var rootElement = EndnotesConverter.CreateOpenXmlElement<DXW.Endnotes>(value);
         if (rootElement != null)
           _ExistingElement.Endnotes = rootElement;
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
