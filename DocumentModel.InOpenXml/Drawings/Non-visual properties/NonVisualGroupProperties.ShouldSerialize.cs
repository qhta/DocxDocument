namespace DocumentModel.Drawings;

public partial class NonVisualGroupProperties
{
  public bool ShouldSerializeIsLegacyGroup() => IsLegacyGroup is not null;
}
