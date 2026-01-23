namespace DocumentModel.Drawings;

public partial class CharacterBullet
{
  public bool ShouldSerializeChar() => Char is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
