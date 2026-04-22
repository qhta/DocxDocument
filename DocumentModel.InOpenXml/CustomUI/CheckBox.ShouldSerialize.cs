namespace DocumentModel.CustomUI;

#pragma warning disable CS1591

public partial class CheckBox
{
  public bool ShouldSerializeGetPressed() => !String.IsNullOrEmpty(GetPressed);
  public bool ShouldSerializeOnAction() => !String.IsNullOrEmpty(OnAction);
  public bool ShouldSerializeEnabled() => Enabled is not null;
  public bool ShouldSerializeGetEnabled() => !String.IsNullOrEmpty(GetEnabled);
  public bool ShouldSerializeDescription() => !String.IsNullOrEmpty(Description);
  public bool ShouldSerializeGetDescription() => !String.IsNullOrEmpty(GetDescription);
  public bool ShouldSerializeId() => !String.IsNullOrEmpty(Id);
  public bool ShouldSerializeQualifiedId() => !String.IsNullOrEmpty(QualifiedId);
  public bool ShouldSerializeTag() => !String.IsNullOrEmpty(Tag);
  public bool ShouldSerializeIdMso() => !String.IsNullOrEmpty(IdMso);
  public bool ShouldSerializeScreentip() => !String.IsNullOrEmpty(Screentip);
  public bool ShouldSerializeGetScreentip() => !String.IsNullOrEmpty(GetScreentip);
  public bool ShouldSerializeSupertip() => !String.IsNullOrEmpty(Supertip);
  public bool ShouldSerializeGetSupertip() => !String.IsNullOrEmpty(GetSupertip);
  public bool ShouldSerializeLabel() => !String.IsNullOrEmpty(Label);
  public bool ShouldSerializeGetLabel() => !String.IsNullOrEmpty(GetLabel);
  public bool ShouldSerializeInsertAfterMso() => !String.IsNullOrEmpty(InsertAfterMso);
  public bool ShouldSerializeInsertBeforeMso() => !String.IsNullOrEmpty(InsertBeforeMso);
  public bool ShouldSerializeInsertAfterQualifiedId() => !String.IsNullOrEmpty(InsertAfterQualifiedId);
  public bool ShouldSerializeInsertBeforeQualifiedId() => !String.IsNullOrEmpty(InsertBeforeQualifiedId);
  public bool ShouldSerializeVisible() => Visible is not null;
  public bool ShouldSerializeGetVisible() => !String.IsNullOrEmpty(GetVisible);
  public bool ShouldSerializeKeytip() => !String.IsNullOrEmpty(Keytip);
  public bool ShouldSerializeGetKeytip() => !String.IsNullOrEmpty(GetKeytip);
}
