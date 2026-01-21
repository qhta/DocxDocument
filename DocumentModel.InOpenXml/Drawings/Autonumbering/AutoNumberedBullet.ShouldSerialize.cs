namespace DocumentModel.Drawings;

public partial class AutoNumberedBullet
{
  public bool ShouldSerializeType() => Type is not null;
  public bool ShouldSerializeStartAt() => StartAt is not null;
}
