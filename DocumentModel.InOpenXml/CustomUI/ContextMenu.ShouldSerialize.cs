namespace DocumentModel.CustomUI;

#pragma warning disable CS1591

public partial class ContextMenu
{
  public bool ShouldSerializeIdMso() => !String.IsNullOrEmpty(IdMso);
}
