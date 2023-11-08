namespace DocumentModel.Packaging;


/// <summary>
///   Defines the WebExtensionPart
/// </summary>
public partial class WebExtensionPart: ModelElement<DXPack.WebExtensionPart>
{
  public WebExtensionPart(): base(){ }
  
  public WebExtensionPart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public WebExtensionPart(DXPack.WebExtensionPart openXmlElement): base(openXmlElement) { }
  
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
  
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  [DataMember]
  public DMEX.WebExtension? WebExtension
  {
    get
    {
        return WebExtensionConverter.CreateModelElement(_Element?.RootElement as DXO13WE.WebExtension);
    }
    set
    {
      if (value != null)
      {
         var rootElement = WebExtensionConverter.CreateOpenXmlElement<DXO13WE.WebExtension>(value);
         if (rootElement != null)
           _ExistingElement.WebExtension = rootElement;
      }
    }
  }
  
}
