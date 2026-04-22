namespace DocumentModel.CustomUI;

#pragma warning disable CS1591

public partial class RadioGroup
{
  public bool ShouldSerializeId() => !String.IsNullOrEmpty(Id);
  public bool ShouldSerializeQualifiedId() => !String.IsNullOrEmpty(QualifiedId);
  public bool ShouldSerializeTag() => !String.IsNullOrEmpty(Tag);
  public bool ShouldSerializeAlignLabel() => AlignLabel is not null;
  public bool ShouldSerializeExpand() => Expand is not null;
  public bool ShouldSerializeEnabled() => Enabled is not null;
  public bool ShouldSerializeGetEnabled() => !String.IsNullOrEmpty(GetEnabled);
  public bool ShouldSerializeLabel() => !String.IsNullOrEmpty(Label);
  public bool ShouldSerializeGetLabel() => !String.IsNullOrEmpty(GetLabel);
  public bool ShouldSerializeVisible() => Visible is not null;
  public bool ShouldSerializeGetVisible() => !String.IsNullOrEmpty(GetVisible);
  public bool ShouldSerializeOnAction() => !String.IsNullOrEmpty(OnAction);
  public bool ShouldSerializeKeytip() => !String.IsNullOrEmpty(Keytip);
  public bool ShouldSerializeGetKeytip() => !String.IsNullOrEmpty(GetKeytip);
  public bool ShouldSerializeGetSelectedItemIndex() => !String.IsNullOrEmpty(GetSelectedItemIndex);
  public bool ShouldSerializeGetItemCount() => !String.IsNullOrEmpty(GetItemCount);
  public bool ShouldSerializeGetItemLabel() => !String.IsNullOrEmpty(GetItemLabel);
  public bool ShouldSerializeGetItemID() => !String.IsNullOrEmpty(GetItemID);
}
