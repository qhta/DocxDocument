namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class PictureBullet
{
  public bool ShouldSerializeBlip() => Blip is not null;
}
