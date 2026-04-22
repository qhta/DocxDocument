namespace DocumentModel.CustomUI;

#pragma warning disable CS1591

public partial class LayoutContainer
{
  public bool ShouldSerializeId() => !String.IsNullOrEmpty(Id);
  public bool ShouldSerializeQualifiedId() => !String.IsNullOrEmpty(QualifiedId);
  public bool ShouldSerializeTag() => !String.IsNullOrEmpty(Tag);
  public bool ShouldSerializeAlign() => Align is not null;
  public bool ShouldSerializeExpand() => Expand is not null;
  public bool ShouldSerializeLayoutChildren() => LayoutChildren is not null;
}
