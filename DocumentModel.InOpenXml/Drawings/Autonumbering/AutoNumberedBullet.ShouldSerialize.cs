namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class AutoNumberedBullet
{
  public bool ShouldSerializeType() => Type is not null;
  public bool ShouldSerializeStartAt() => StartAt is not null;
}
