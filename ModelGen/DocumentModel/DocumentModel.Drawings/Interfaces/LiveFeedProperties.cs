namespace DocumentModel.Drawings;

/// <summary>
/// Defines the LiveFeedProperties Class.
/// </summary>
public interface LiveFeedProperties
{
  /// <summary>
  /// LiveFeedBackgroundProperties.
  /// </summary>
  public LiveFeedBackgroundProperties? LiveFeedBackgroundProperties { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList2? OfficeArtExtensionList { get ; set; }
  
}
