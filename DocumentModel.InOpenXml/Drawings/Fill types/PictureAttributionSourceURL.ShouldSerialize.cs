namespace DocumentModel.Drawings;

public partial class PictureAttributionSourceURL
{
  public bool ShouldSerializeId() => Id is not null;
}
