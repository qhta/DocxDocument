namespace DocumentModel.CustomUI;

#pragma warning disable CS1591

public partial class TaskFormGroupCategory
{
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
  public bool ShouldSerializeLabel() => !String.IsNullOrEmpty(Label);
  public bool ShouldSerializeGetLabel() => !String.IsNullOrEmpty(GetLabel);
}
