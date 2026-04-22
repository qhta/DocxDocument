namespace DocumentModel.CustomUI;

#pragma warning disable CS1591

public partial class BackstageTab
{
  public bool ShouldSerializeId() => !String.IsNullOrEmpty(Id);
  public bool ShouldSerializeQualifiedId() => !String.IsNullOrEmpty(QualifiedId);
  public bool ShouldSerializeTag() => !String.IsNullOrEmpty(Tag);
  public bool ShouldSerializeIdMso() => !String.IsNullOrEmpty(IdMso);
  public bool ShouldSerializeInsertAfterMso() => !String.IsNullOrEmpty(InsertAfterMso);
  public bool ShouldSerializeInsertBeforeMso() => !String.IsNullOrEmpty(InsertBeforeMso);
  public bool ShouldSerializeInsertAfterQualifiedId() => !String.IsNullOrEmpty(InsertAfterQualifiedId);
  public bool ShouldSerializeInsertBeforeQualifiedId() => !String.IsNullOrEmpty(InsertBeforeQualifiedId);
  public bool ShouldSerializeEnabled() => Enabled is not null;
  public bool ShouldSerializeGetEnabled() => !String.IsNullOrEmpty(GetEnabled);
  public bool ShouldSerializeLabel() => !String.IsNullOrEmpty(Label);
  public bool ShouldSerializeGetLabel() => !String.IsNullOrEmpty(GetLabel);
  public bool ShouldSerializeVisible() => Visible is not null;
  public bool ShouldSerializeGetVisible() => !String.IsNullOrEmpty(GetVisible);
  public bool ShouldSerializeKeytip() => !String.IsNullOrEmpty(Keytip);
  public bool ShouldSerializeGetKeytip() => !String.IsNullOrEmpty(GetKeytip);
  public bool ShouldSerializeTitle() => !String.IsNullOrEmpty(Title);
  public bool ShouldSerializeGetTitle() => !String.IsNullOrEmpty(GetTitle);
  public bool ShouldSerializeColumnWidthPercent() => ColumnWidthPercent is not null;
  public bool ShouldSerializeFirstColumnMinWidth() => FirstColumnMinWidth is not null;
  public bool ShouldSerializeFirstColumnMaxWidth() => FirstColumnMaxWidth is not null;
  public bool ShouldSerializeSecondColumnMinWidth() => SecondColumnMinWidth is not null;
  public bool ShouldSerializeSecondColumnMaxWidth() => SecondColumnMaxWidth is not null;
  public bool ShouldSerializeBackstageGroups() => BackstageGroups is not null;
  public bool ShouldSerializeSimpleGroups() => SimpleGroups is not null;
}
