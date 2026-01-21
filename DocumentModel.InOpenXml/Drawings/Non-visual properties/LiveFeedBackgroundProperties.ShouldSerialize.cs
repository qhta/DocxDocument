namespace DocumentModel.Drawings;

public partial class LiveFeedBackgroundProperties
{
  public bool ShouldSerializeBackgroundNormalProperties() => BackgroundNormalProperties is not null;
  public bool ShouldSerializeBackgroundRemovedProperties() => BackgroundRemovedProperties is not null;
  public bool ShouldSerializeBackgroundBlurProperties() => BackgroundBlurProperties is not null;
  public bool ShouldSerializeBackgroundCustomProperties() => BackgroundCustomProperties is not null;
  public bool ShouldSerializeOfficeArtExtensionList() => OfficeArtExtensionList is not null;
}
