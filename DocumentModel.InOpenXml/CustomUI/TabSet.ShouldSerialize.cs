namespace DocumentModel.CustomUI;

#pragma warning disable CS1591

public partial class TabSet
{
  public bool ShouldSerializeIdMso() => !String.IsNullOrEmpty(IdMso);
  public bool ShouldSerializeVisible() => Visible is not null;
  public bool ShouldSerializeGetVisible() => !String.IsNullOrEmpty(GetVisible);
}
