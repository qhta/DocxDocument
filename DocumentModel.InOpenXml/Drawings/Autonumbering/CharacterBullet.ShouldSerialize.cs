namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class CharacterBullet
{
  public bool ShouldSerializeChar() => !String.IsNullOrEmpty(Char);
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
