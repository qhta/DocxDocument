namespace DocumentModel.CustomUI;

#pragma warning disable CS1591

public partial class MenuRoot
{
  public bool ShouldSerializeTitle() => !String.IsNullOrEmpty(Title);
  public bool ShouldSerializeGetTitle() => !String.IsNullOrEmpty(GetTitle);
  public bool ShouldSerializeItemSize() => ItemSize is not null;
}
