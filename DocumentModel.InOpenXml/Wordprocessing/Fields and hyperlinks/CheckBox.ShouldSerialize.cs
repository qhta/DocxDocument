namespace DocumentModel.Wordprocessing;

public partial class CheckBox
{
  public bool ShouldSerializeFormFieldSize() => FormFieldSize is not null;
  public bool ShouldSerializeAutomaticallySizeFormField() => AutomaticallySizeFormField is not null;
  public bool ShouldSerializeDefaultCheckBoxFormFieldState() => DefaultCheckBoxFormFieldState is not null;
  public bool ShouldSerializeChecked() => Checked is not null;
}
