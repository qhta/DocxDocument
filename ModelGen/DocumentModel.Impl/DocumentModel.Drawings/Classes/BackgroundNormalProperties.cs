namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BackgroundNormalProperties Class.
/// </summary>
public class BackgroundNormalPropertiesImpl: ModelElementImpl, BackgroundNormalProperties
{
  public DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundNormalProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundNormalProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public BackgroundNormalPropertiesImpl(): base() {}
  
  public BackgroundNormalPropertiesImpl(DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundNormalProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
