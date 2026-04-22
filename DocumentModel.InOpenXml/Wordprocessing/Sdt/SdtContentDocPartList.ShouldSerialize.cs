namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class SdtContentDocPartList
{
  public bool ShouldSerializeDocPartGallery() => !String.IsNullOrEmpty(DocPartGallery);
  public bool ShouldSerializeDocPartCategory() => !String.IsNullOrEmpty(DocPartCategory);
  public bool ShouldSerializeDocPartUnique() => DocPartUnique is not null;
}
