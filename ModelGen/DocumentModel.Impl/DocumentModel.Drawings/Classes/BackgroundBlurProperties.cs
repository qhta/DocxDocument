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
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList2? OfficeArtExtensionList
  {
    get;
    set;
  }
  
}
