namespace DocumentModel.Drawings.Diagram1;
#pragma warning disable CS1591
public partial class DiagramAutoBullet
{
  public bool ShouldSerializeAutoBulletPrefix() => !String.IsNullOrEmpty(AutoBulletPrefix);
  public bool ShouldSerializeLeadZeros() => LeadZeros is not null;
  public bool ShouldSerializeNoBullet() => NoBullet is not null;
  public bool ShouldSerializeAutoNumberedBullet() => AutoNumberedBullet is not null;
  public bool ShouldSerializeCharacterBullet() => CharacterBullet is not null;
  public bool ShouldSerializePictureBullet() => PictureBullet is not null;
}
