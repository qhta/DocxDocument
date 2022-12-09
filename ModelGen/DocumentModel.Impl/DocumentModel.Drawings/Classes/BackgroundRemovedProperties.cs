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
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList6? OfficeArtExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
