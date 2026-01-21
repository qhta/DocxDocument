namespace DocumentModel.Wordprocessing.Drawings;

public partial class RelativeWidth
{
  public bool ShouldSerializeObjectId() => ObjectId is not null;
  public bool ShouldSerializePercentageWidth() => PercentageWidth is not null;
}
