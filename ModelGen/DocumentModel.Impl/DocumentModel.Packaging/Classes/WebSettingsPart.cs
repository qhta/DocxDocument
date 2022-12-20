namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WebSettingsPart
/// </summary>
public partial class WebSettingsPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, WebSettingsPart
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.Packaging.WebSettingsPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.WebSettingsPart?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public WebSettingsPartImpl(): base() {}
  
  public WebSettingsPartImpl(DocumentFormat.OpenXml.Packaging.WebSettingsPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.WebSettings? WebSettings
  {
    get
    {
      if (OpenXmlElement?.WebSettings != null)
        return new DocumentModel.Wordprocessing.WebSettingsImpl(OpenXmlElement.WebSettings);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      if (value is DocumentModel.Wordprocessing.WebSettingsImpl valueImpl)
        if (valueImpl.OpenXmlElement != null)
            OpenXmlElement.WebSettings = valueImpl.OpenXmlElement;
    }
  }
  
}
