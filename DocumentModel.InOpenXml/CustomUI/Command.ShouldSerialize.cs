namespace DocumentModel.CustomUI;

#pragma warning disable CS1591

public partial class Command
{
  public bool ShouldSerializeOnAction() => !String.IsNullOrEmpty(OnAction);
  public bool ShouldSerializeEnabled() => Enabled is not null;
  public bool ShouldSerializeGetEnabled() => !String.IsNullOrEmpty(GetEnabled);
  public bool ShouldSerializeIdMso() => !String.IsNullOrEmpty(IdMso);
}
