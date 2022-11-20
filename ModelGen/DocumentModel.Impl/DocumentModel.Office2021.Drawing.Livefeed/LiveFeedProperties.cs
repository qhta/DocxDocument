namespace DocumentModel.Office2021.Drawing.Livefeed;

/// <summary>
/// Defines the LiveFeedProperties Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2021.Drawing.Livefeed.IOfficeArtExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2021.Drawing.Livefeed.ILiveFeedBackgroundProperties))]
public class LiveFeedProperties: ILiveFeedProperties
{
  /// <summary>
  /// LiveFeedBackgroundProperties.
  /// </summary>
  public ILiveFeedBackgroundProperties? LiveFeedBackgroundProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Office2021.Drawing.Livefeed.IOfficeArtExtensionList? OfficeArtExtensionList
  {
    get;
    set;
  }
  
}
