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
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList2? OfficeArtExtensionList
  {
    get;
    set;
  }
  
}
