namespace DocumentModel.Packaging;


/// <summary>
///   An instance of this part contains the names of custom file properties that apply to the package, their values, and the types of those values. A custom file property might be the name of the client for whom the document was prepared, a date/time on which some event happened, a document number, or some Boolean status flag.
/// </summary>
public partial class CustomFilePropertiesPart: ModelPartElement<DXPack.CustomFilePropertiesPart>
{
  public CustomFilePropertiesPart(): base(){ }
  
  public CustomFilePropertiesPart(DXPack.OpenXmlPart openXmlElement): base(openXmlElement) { }
  
  public CustomFilePropertiesPart(DXPack.CustomFilePropertiesPart openXmlElement): base(openXmlElement) { }
  
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
  public DocumentModel.Properties.CustomProperties? Properties
  {
    get
    {
        return CustomPropertiesConverter.CreateModelElement(_Element?.RootElement as DXCP.Properties);
    }
    set
    {
      if (value != null)
      {
         var rootElement = CustomPropertiesConverter.CreateOpenXmlElement<DXCP.Properties>(value);
         if (rootElement != null)
           _ExistingElement.Properties = rootElement;
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
