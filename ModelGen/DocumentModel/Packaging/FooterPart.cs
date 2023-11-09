namespace DocumentModel.Packaging;


/// <summary>
///   An instance of this part type contains the information about a footer displayed for one or more sections.
/// </summary>
public partial class FooterPart: ModelPartElement<DXPack.FooterPart>
{
  public FooterPart(): base(){ }
  
  public FooterPart(DXPack.OpenXmlPart openXmlElement): base(openXmlElement) { }
  
  public FooterPart(DXPack.FooterPart openXmlElement): base(openXmlElement) { }
  
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
  public DMW.Footer? Footer
  {
    get
    {
        return FooterConverter.CreateModelElement(_Element?.RootElement as DXW.Footer);
    }
    set
    {
      if (value != null)
      {
         var rootElement = FooterConverter.CreateOpenXmlElement<DXW.Footer>(value);
         if (rootElement != null)
           _ExistingElement.Footer = rootElement;
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
