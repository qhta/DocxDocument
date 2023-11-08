namespace DocumentModel.Packaging;


/// <summary>
///   An instance of this part type contains the information about a header displayed for one or more sections.
/// </summary>
public partial class HeaderPart: ModelElement<DXPack.HeaderPart>
{
  public HeaderPart(): base(){ }
  
  public HeaderPart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public HeaderPart(DXPack.HeaderPart openXmlElement): base(openXmlElement) { }
  
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
  public DMW.Header? Header
  {
    get
    {
        return HeaderConverter.CreateModelElement(_Element?.RootElement as DXW.Header);
    }
    set
    {
      if (value != null)
      {
         var rootElement = HeaderConverter.CreateOpenXmlElement<DXW.Header>(value);
         if (rootElement != null)
           _ExistingElement.Header = rootElement;
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
