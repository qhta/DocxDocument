namespace DocumentModel.Drawings;

public partial class LiveFeedProperties
{
  public bool ShouldSerializeLiveFeedBackgroundProperties() => LiveFeedBackgroundProperties is not null;
  public bool ShouldSerializeOfficeArtExtensionList() => OfficeArtExtensionList is not null;
}
