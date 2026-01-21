namespace DocumentModel.Wordprocessing;

public partial class SdtContentCheckBox
{
  public bool ShouldSerializeChecked() => Checked is not null;
  public bool ShouldSerializeCheckedState() => CheckedState is not null;
  public bool ShouldSerializeUncheckedState() => UncheckedState is not null;
}
