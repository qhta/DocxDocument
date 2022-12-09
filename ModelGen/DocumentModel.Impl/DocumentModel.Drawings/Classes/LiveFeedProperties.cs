namespace DocumentModel.Drawings;

/// <summary>
/// Defines the LiveFeedProperties Class.
/// </summary>
public class LiveFeedPropertiesImpl: ModelElementImpl, LiveFeedProperties
{
  public DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.LiveFeedProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.LiveFeedProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// LiveFeedBackgroundProperties.
  /// </summary>
  public LiveFeedBackgroundProperties? LiveFeedBackgroundProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
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
