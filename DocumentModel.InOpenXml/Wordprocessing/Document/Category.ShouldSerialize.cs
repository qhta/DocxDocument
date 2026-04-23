namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class Category
{
  public bool ShouldSerializeName() => !String.IsNullOrEmpty(Name);
  public bool ShouldSerializeGallery() => Gallery is not null && ShouldSerialize(Gallery);
}
