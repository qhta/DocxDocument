namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class Category
{
  public bool ShouldSerializeName() => Name is not null;
  public bool ShouldSerializeGallery() => Gallery is not null;
}
