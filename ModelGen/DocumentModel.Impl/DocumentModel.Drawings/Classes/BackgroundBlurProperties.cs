namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BackgroundBlurProperties Class.
/// </summary>
public class BackgroundBlurPropertiesImpl: ModelElementImpl, BackgroundBlurProperties
{
  public DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundBlurProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundBlurProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public BackgroundBlurPropertiesImpl(): base() {}
  
  public BackgroundBlurPropertiesImpl(DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundBlurProperties openXmlElement): base(openXmlElement)
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
