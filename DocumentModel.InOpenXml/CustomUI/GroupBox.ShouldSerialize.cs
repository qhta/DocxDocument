namespace DocumentModel.CustomUI;

#pragma warning disable CS1591

public partial class GroupBox
{
  public bool ShouldSerializeId() => !String.IsNullOrEmpty(Id);
  public bool ShouldSerializeQualifiedId() => !String.IsNullOrEmpty(QualifiedId);
  public bool ShouldSerializeTag() => !String.IsNullOrEmpty(Tag);
  public bool ShouldSerializeExpand() => Expand is not null;
  public bool ShouldSerializeLabel() => !String.IsNullOrEmpty(Label);
  public bool ShouldSerializeGetLabel() => !String.IsNullOrEmpty(GetLabel);
}
