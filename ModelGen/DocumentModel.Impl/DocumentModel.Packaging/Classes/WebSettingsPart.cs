namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WebSettingsPart
/// </summary>
public class WebSettingsPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, WebSettingsPart
{
  public new DocumentFormat.OpenXml.Packaging.WebSettingsPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.WebSettingsPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public WebSettingsPartImpl(): base() {}
  
  public WebSettingsPartImpl(DocumentFormat.OpenXml.Packaging.WebSettingsPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.WebSettingsPart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.WebSettingsPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.WebSettings? WebSettings
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
