namespace DocumentModel.Drawings;
/// <summary>
///   Represents properties for a live feed, including background and extension settings.
/// </summary>
public partial class LiveFeedProperties : ModelElement<DXO21DL.LiveFeedProperties>, IOfficeArtExtendableElement
{
  /// <summary>
  ///   Background properties for the live feed.
  /// </summary>
  public LiveFeedBackgroundProperties? LiveFeedBackgroundProperties { get; set; }
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}