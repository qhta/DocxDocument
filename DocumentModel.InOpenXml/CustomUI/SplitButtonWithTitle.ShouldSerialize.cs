namespace DocumentModel.CustomUI;

#pragma warning disable CS1591

public partial class SplitButtonWithTitle
{
  public bool ShouldSerializeEnabled() => Enabled is not null;
  public bool ShouldSerializeGetEnabled() => !String.IsNullOrEmpty(GetEnabled);
  public bool ShouldSerializeId() => !String.IsNullOrEmpty(Id);
  public bool ShouldSerializeQualifiedId() => !String.IsNullOrEmpty(QualifiedId);
  public bool ShouldSerializeTag() => !String.IsNullOrEmpty(Tag);
  public bool ShouldSerializeIdMso() => !String.IsNullOrEmpty(IdMso);
  public bool ShouldSerializeInsertAfterMso() => !String.IsNullOrEmpty(InsertAfterMso);
  public bool ShouldSerializeInsertBeforeMso() => !String.IsNullOrEmpty(InsertBeforeMso);
  public bool ShouldSerializeInsertAfterQualifiedId() => !String.IsNullOrEmpty(InsertAfterQualifiedId);
  public bool ShouldSerializeInsertBeforeQualifiedId() => !String.IsNullOrEmpty(InsertBeforeQualifiedId);
  public bool ShouldSerializeVisible() => Visible is not null;
  public bool ShouldSerializeGetVisible() => !String.IsNullOrEmpty(GetVisible);
  public bool ShouldSerializeKeytip() => !String.IsNullOrEmpty(Keytip);
  public bool ShouldSerializeGetKeytip() => !String.IsNullOrEmpty(GetKeytip);
  public bool ShouldSerializeShowLabel() => ShowLabel is not null;
  public bool ShouldSerializeGetShowLabel() => !String.IsNullOrEmpty(GetShowLabel);
}
