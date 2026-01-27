namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class CharacterBullet
{
  public bool ShouldSerializeChar() => Char is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
