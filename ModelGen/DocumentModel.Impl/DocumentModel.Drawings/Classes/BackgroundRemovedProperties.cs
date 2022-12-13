namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BackgroundRemovedProperties Class.
/// </summary>
public class BackgroundRemovedPropertiesImpl: ModelElementImpl, BackgroundRemovedProperties
{
  public DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundRemovedProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundRemovedProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public BackgroundRemovedPropertiesImpl(): base() {}
  
  public BackgroundRemovedPropertiesImpl(DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundRemovedProperties openXmlElement): base(openXmlElement)
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
