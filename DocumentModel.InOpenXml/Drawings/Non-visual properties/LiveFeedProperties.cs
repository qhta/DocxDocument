namespace DocumentModel.Drawings;

/// <summary>
///   Represents properties for a live feed, including background and extension settings.
/// </summary>
public interface LiveFeedProperties: IOfficeArtExtendableElement
{
  /// <summary>
  ///   Background properties for the live feed.
  /// </summary>
  public LiveFeedBackgroundProperties? LiveFeedBackgroundProperties { get; set; }
}