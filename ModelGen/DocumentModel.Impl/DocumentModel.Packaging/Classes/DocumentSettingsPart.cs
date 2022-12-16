namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DocumentSettingsPart
/// </summary>
public class DocumentSettingsPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, DocumentSettingsPart
{
  public new DocumentFormat.OpenXml.Packaging.DocumentSettingsPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.DocumentSettingsPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DocumentSettingsPartImpl(): base() {}
  
  public DocumentSettingsPartImpl(DocumentFormat.OpenXml.Packaging.DocumentSettingsPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.DocumentSettingsPart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  /// <summary>
  /// Gets the ImageParts of the DocumentSettingsPart
  /// </summary>
  public DocumentModel.Packaging.ImagePart? ImageParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.DocumentSettingsPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.Settings? Settings
  {
    get
    {
      if (OpenXmlElement?.Settings != null)
        return new DocumentModel.Wordprocessing.SettingsImpl(OpenXmlElement.Settings);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      if (value is DocumentModel.Wordprocessing.SettingsImpl valueImpl)
        if (valueImpl.OpenXmlElement != null)
            OpenXmlElement.Settings = valueImpl.OpenXmlElement;
    }
  }
  
}
