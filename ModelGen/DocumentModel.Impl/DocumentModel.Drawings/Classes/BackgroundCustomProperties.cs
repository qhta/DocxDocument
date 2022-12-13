namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BackgroundCustomProperties Class.
/// </summary>
public class BackgroundCustomPropertiesImpl: ModelElementImpl, BackgroundCustomProperties
{
  public DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundCustomProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundCustomProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public BackgroundCustomPropertiesImpl(): base() {}
  
  public BackgroundCustomPropertiesImpl(DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundCustomProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Drawings.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
