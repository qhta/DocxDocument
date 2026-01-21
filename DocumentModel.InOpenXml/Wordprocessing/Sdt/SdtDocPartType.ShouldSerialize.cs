namespace DocumentModel.Wordprocessing;

public partial class SdtDocPartType
{
  public bool ShouldSerializeDocPartGallery() => DocPartGallery is not null;
  public bool ShouldSerializeDocPartCategory() => DocPartCategory is not null;
  public bool ShouldSerializeDocPartUnique() => DocPartUnique is not null;
}
