namespace DocumentModel.Drawings;
/// <summary>
///   Represents properties for a live feed, including background and extension settings.
/// </summary>
public partial class LiveFeedProperties : ModelElement<DXO21DL.LiveFeedProperties>, IOfficeArtExtendableElement
{
    /// <summary>
    ///   Background properties for the live feed.
    /// </summary>
    [OpenXmlProperty(nameof(DXO21DL.LiveFeedProperties.LiveFeedBackgroundProperties))]
    public LiveFeedBackgroundProperties? LiveFeedBackgroundProperties { get => _LiveFeedBackgroundProperties; set => UpdateField(ref _LiveFeedBackgroundProperties, value, nameof(LiveFeedBackgroundProperties)); }

    private LiveFeedBackgroundProperties? _LiveFeedBackgroundProperties;
    [OpenXmlProperty(nameof(DXO21DL.LiveFeedProperties.OfficeArtExtensionList))]
    public OfficeArtExtensionList? OfficeArtExtensionList { get => _OfficeArtExtensionList; set => UpdateField(ref _OfficeArtExtensionList, value, nameof(OfficeArtExtensionList)); }

    private OfficeArtExtensionList? _OfficeArtExtensionList;
}