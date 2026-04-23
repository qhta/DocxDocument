namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class CheckBox
{
  public bool ShouldSerializeFormFieldSize() => !String.IsNullOrEmpty(FormFieldSize);
  public bool ShouldSerializeAutomaticallySizeFormField() => AutomaticallySizeFormField is not null;
  public bool ShouldSerializeDefaultCheckBoxFormFieldState() => DefaultCheckBoxFormFieldState is not null;
  public bool ShouldSerializeChecked() => Checked is not null;
}
