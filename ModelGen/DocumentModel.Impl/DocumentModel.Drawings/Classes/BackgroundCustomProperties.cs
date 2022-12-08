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
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList2? OfficeArtExtensionList
  {
    get;
    set;
  }
  
}
