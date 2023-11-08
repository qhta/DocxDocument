namespace DocumentModel.Packaging;


/// <summary>
///   An instance of this part type contains the definition for web-specific settings used by this document.
/// </summary>
public partial class WebSettingsPart: ModelElement<DXPack.WebSettingsPart>
{
  public WebSettingsPart(): base(){ }
  
  public WebSettingsPart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public WebSettingsPart(DXPack.WebSettingsPart openXmlElement): base(openXmlElement) { }
  
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
  public DM.WebSettings? WebSettings
  {
    get
    {
        return WebSettingsConverter.CreateModelElement(_Element?.RootElement as DXW.WebSettings);
    }
    set
    {
      if (value != null)
      {
         var rootElement = WebSettingsConverter.CreateOpenXmlElement<DXW.WebSettings>(value);
         if (rootElement != null)
           _ExistingElement.WebSettings = rootElement;
      }
    }
  }
  
}
