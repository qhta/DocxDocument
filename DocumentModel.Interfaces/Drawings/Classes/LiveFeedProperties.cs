namespace DocumentModel.Drawings;

/// <summary>
///   Defines the LiveFeedProperties Class.
/// </summary>
public class LiveFeedProperties: ModelElement
{
  /// <summary>
  ///   LiveFeedBackgroundProperties.
  /// </summary>
  public LiveFeedBackgroundProperties? LiveFeedBackgroundProperties { get; set; }
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}