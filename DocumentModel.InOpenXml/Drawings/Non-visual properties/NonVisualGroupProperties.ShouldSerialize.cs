namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class NonVisualGroupProperties
{
  public bool ShouldSerializeIsLegacyGroup() => IsLegacyGroup is not null;
}
