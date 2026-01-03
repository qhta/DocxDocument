namespace DocumentModel.Drawings;

/// <summary>
///   Defines the LiveFeedProperties interface.
/// </summary>
public interface LiveFeedProperties: IModelElement
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