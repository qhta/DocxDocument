namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class SdtDocPartType
{
  public bool ShouldSerializeDocPartGallery() => DocPartGallery is not null;
  public bool ShouldSerializeDocPartCategory() => DocPartCategory is not null;
  public bool ShouldSerializeDocPartUnique() => DocPartUnique is not null;
}
