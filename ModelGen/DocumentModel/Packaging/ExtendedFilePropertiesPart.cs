namespace DocumentModel.Packaging;


/// <summary>
///   An instance of this part contains properties specific to an Office Open XML document.
/// </summary>
public partial class ExtendedFilePropertiesPart: ModelElement<DXPack.ExtendedFilePropertiesPart>
{
  public ExtendedFilePropertiesPart(): base(){ }
  
  public ExtendedFilePropertiesPart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ExtendedFilePropertiesPart(DXPack.ExtendedFilePropertiesPart openXmlElement): base(openXmlElement) { }
  
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
  public DocumentModel.Properties.ExtendedProperties? Properties
  {
    get
    {
        return ExtendedPropertiesConverter.CreateModelElement(_Element?.RootElement as DXEP.Properties);
    }
    set
    {
      if (value != null)
      {
         var rootElement = ExtendedPropertiesConverter.CreateOpenXmlElement<DXEP.Properties>(value);
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
