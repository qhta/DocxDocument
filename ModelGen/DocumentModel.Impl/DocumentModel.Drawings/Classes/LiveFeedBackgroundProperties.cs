namespace DocumentModel.Drawings;

/// <summary>
/// Defines the LiveFeedBackgroundProperties Class.
/// </summary>
public class LiveFeedBackgroundPropertiesImpl: ModelElementImpl, LiveFeedBackgroundProperties
{
  public DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.LiveFeedBackgroundProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.LiveFeedBackgroundProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public BackgroundNormalProperties? BackgroundNormalProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public BackgroundRemovedProperties? BackgroundRemovedProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public BackgroundBlurProperties? BackgroundBlurProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public BackgroundCustomProperties? BackgroundCustomProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public OfficeArtExtensionList6? OfficeArtExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
