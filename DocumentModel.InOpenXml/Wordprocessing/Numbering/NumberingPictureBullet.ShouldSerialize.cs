namespace DocumentModel.Wordprocessing;

public partial class NumberingPictureBullet
{
  public bool ShouldSerializeNumberingPictureBulletId() => NumberingPictureBulletId is not null;
  public bool ShouldSerializePictureBulletBase() => PictureBulletBase is not null;
  public bool ShouldSerializeDrawing() => Drawing is not null;
}
