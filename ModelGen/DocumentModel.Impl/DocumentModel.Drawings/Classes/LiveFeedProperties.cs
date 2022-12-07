namespace DocumentModel.Drawings;

/// <summary>
/// Defines the LiveFeedProperties Class.
/// </summary>
public class LiveFeedPropertiesImpl: ModelElement<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.LiveFeedProperties>, LiveFeedProperties
{
  /// <summary>
  /// LiveFeedBackgroundProperties.
  /// </summary>
  public LiveFeedBackgroundProperties? LiveFeedBackgroundProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList8? OfficeArtExtensionList
  {
    get;
    set;
  }
  
}
