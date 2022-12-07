namespace DocumentModel.Drawings;

/// <summary>
/// Defines the LiveFeedBackgroundProperties Class.
/// </summary>
public class LiveFeedBackgroundPropertiesImpl: ModelElement<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.LiveFeedBackgroundProperties>, LiveFeedBackgroundProperties
{
  public BackgroundNormalProperties? BackgroundNormalProperties
  {
    get;
    set;
  }
  
  public BackgroundRemovedProperties? BackgroundRemovedProperties
  {
    get;
    set;
  }
  
  public BackgroundBlurProperties? BackgroundBlurProperties
  {
    get;
    set;
  }
  
  public BackgroundCustomProperties? BackgroundCustomProperties
  {
    get;
    set;
  }
  
  public OfficeArtExtensionList8? OfficeArtExtensionList
  {
    get;
    set;
  }
  
}
