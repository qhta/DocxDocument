namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class NumberingPictureBullet
{
  public bool ShouldSerializeNumberingPictureBulletId() => NumberingPictureBulletId is not null && ShouldSerialize(NumberingPictureBulletId);
  public bool ShouldSerializePictureBulletBase() => PictureBulletBase is not null && ShouldSerialize(PictureBulletBase);
  public bool ShouldSerializeDrawing() => Drawing is not null && ShouldSerialize(Drawing);
}
