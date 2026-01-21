namespace DocumentModel.Wordprocessing;

public partial class Category
{
  public bool ShouldSerializeName() => Name is not null;
  public bool ShouldSerializeGallery() => Gallery is not null;
}
