namespace DocumentModel.Drawings;
/// <summary>
///   Represents properties for a live feed in DrawingML, including background formatting and extension data for advanced video or dynamic content scenarios.
///   Enables configuration of live video backgrounds and extensibility for additional live feed features in Office documents.
/// </summary>
[OpenXmlType(typeof(DXO21DL.LiveFeedProperties))]
public partial class LiveFeedProperties : ModelElement<DXO21DL.LiveFeedProperties>, IOfficeArtExtendableElement
{
  /// <summary>
  ///   Background formatting properties for the live feed, specifying fill, color, and visual effects for the video or dynamic content background.
  /// </summary>
  [OpenXmlProperty(nameof(DXO21DL.LiveFeedProperties.LiveFeedBackgroundProperties))]
  public LiveFeedBackgroundProperties? LiveFeedBackgroundProperties { get => _LiveFeedBackgroundProperties; set => UpdateField(ref _LiveFeedBackgroundProperties, value, nameof(LiveFeedBackgroundProperties)); }

  private LiveFeedBackgroundProperties? _LiveFeedBackgroundProperties;

  /// <summary>
  ///   List of OfficeArt extension elements for the live feed, supporting extensibility and application-specific live feed data.
  /// </summary>
  [OpenXmlProperty(nameof(DXO21DL.LiveFeedProperties.OfficeArtExtensionList))]
  public OfficeArtExtensionList? OfficeArtExtensionList { get => _OfficeArtExtensionList; set => UpdateField(ref _OfficeArtExtensionList, value, nameof(OfficeArtExtensionList)); }

  private OfficeArtExtensionList? _OfficeArtExtensionList;
}
