namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class SdtContentCheckBox
{
  public bool ShouldSerializeChecked() => Checked is not null && ShouldSerialize(Checked);
  public bool ShouldSerializeCheckedState() => CheckedState is not null && ShouldSerialize(CheckedState);
  public bool ShouldSerializeUncheckedState() => UncheckedState is not null && ShouldSerialize(UncheckedState);
}
