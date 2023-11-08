namespace DocumentModel.Packaging;


/// <summary>
///   An instance of this part type contains all the document's properties.
/// </summary>
public partial class DocumentSettingsPart: ModelElement<DXPack.DocumentSettingsPart>
{
  public DocumentSettingsPart(): base(){ }
  
  public DocumentSettingsPart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DocumentSettingsPart(DXPack.DocumentSettingsPart openXmlElement): base(openXmlElement) { }
  
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
  public DM.DocumentSettings? Settings
  {
    get
    {
        return DocumentSettingsConverter.CreateModelElement(_Element?.RootElement as DXW.Settings);
    }
    set
    {
      if (value != null)
      {
         var rootElement = DocumentSettingsConverter.CreateOpenXmlElement<DXW.Settings>(value);
         if (rootElement != null)
           _ExistingElement.Settings = rootElement;
      }
    }
  }
  
}
