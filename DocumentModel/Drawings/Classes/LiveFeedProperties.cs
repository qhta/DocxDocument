namespace DocumentModel.Drawings;

/// <summary>
///   Defines the LiveFeedProperties Class.
/// </summary>
public record LiveFeedProperties
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