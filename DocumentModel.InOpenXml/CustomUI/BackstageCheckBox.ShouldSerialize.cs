namespace DocumentModel.CustomUI;

#pragma warning disable CS1591

public partial class BackstageCheckBox
{
  public bool ShouldSerializeExpand() => Expand is not null;
  public bool ShouldSerializeDescription() => !String.IsNullOrEmpty(Description);
  public bool ShouldSerializeGetDescription() => !String.IsNullOrEmpty(GetDescription);
  public bool ShouldSerializeScreentip() => !String.IsNullOrEmpty(Screentip);
  public bool ShouldSerializeGetScreentip() => !String.IsNullOrEmpty(GetScreentip);
  public bool ShouldSerializeSupertip() => !String.IsNullOrEmpty(Supertip);
  public bool ShouldSerializeGetSupertip() => !String.IsNullOrEmpty(GetSupertip);
  public bool ShouldSerializeId() => !String.IsNullOrEmpty(Id);
  public bool ShouldSerializeQualifiedId() => !String.IsNullOrEmpty(QualifiedId);
  public bool ShouldSerializeTag() => !String.IsNullOrEmpty(Tag);
  public bool ShouldSerializeOnAction() => !String.IsNullOrEmpty(OnAction);
  public bool ShouldSerializeGetPressed() => !String.IsNullOrEmpty(GetPressed);
  public bool ShouldSerializeEnabled() => Enabled is not null;
  public bool ShouldSerializeGetEnabled() => !String.IsNullOrEmpty(GetEnabled);
  public bool ShouldSerializeLabel() => !String.IsNullOrEmpty(Label);
  public bool ShouldSerializeGetLabel() => !String.IsNullOrEmpty(GetLabel);
  public bool ShouldSerializeVisible() => Visible is not null;
  public bool ShouldSerializeGetVisible() => !String.IsNullOrEmpty(GetVisible);
  public bool ShouldSerializeKeytip() => !String.IsNullOrEmpty(Keytip);
  public bool ShouldSerializeGetKeytip() => !String.IsNullOrEmpty(GetKeytip);
}
