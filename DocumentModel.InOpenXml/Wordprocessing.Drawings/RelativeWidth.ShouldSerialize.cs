namespace DocumentModel.Wordprocessing.Drawings;

#pragma warning disable CS1591

public partial class RelativeWidth
{
  public bool ShouldSerializeObjectId() => ObjectId is not null;
  public bool ShouldSerializePercentageWidth() => PercentageWidth is not null;
}
