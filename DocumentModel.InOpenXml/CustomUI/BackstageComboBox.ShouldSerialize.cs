namespace DocumentModel.CustomUI;

#pragma warning disable CS1591

public partial class BackstageComboBox
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
  public bool ShouldSerializeKeytip() => !String.IsNullOrEmpty(Keytip);
  public bool ShouldSerializeGetKeytip() => !String.IsNullOrEmpty(GetKeytip);
  public bool ShouldSerializeGetText() => !String.IsNullOrEmpty(GetText);
  public bool ShouldSerializeOnChange() => !String.IsNullOrEmpty(OnChange);
  public bool ShouldSerializeSizeString() => !String.IsNullOrEmpty(SizeString);
  public bool ShouldSerializeGetItemCount() => !String.IsNullOrEmpty(GetItemCount);
  public bool ShouldSerializeGetItemLabel() => !String.IsNullOrEmpty(GetItemLabel);
  public bool ShouldSerializeGetItemID() => !String.IsNullOrEmpty(GetItemID);
}
