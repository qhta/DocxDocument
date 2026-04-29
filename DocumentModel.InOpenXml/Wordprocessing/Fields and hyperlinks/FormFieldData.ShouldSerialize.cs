namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class FormFieldData
{
  public bool ShouldSerializeFormFieldName() => !String.IsNullOrEmpty(FormFieldName);
  public bool ShouldSerializeEnabled() => Enabled is not null;
  public bool ShouldSerializeCalculateOnExit() => CalculateOnExit is not null;
  public bool ShouldSerializeEntryMacro() => !String.IsNullOrEmpty(EntryMacro);
  public bool ShouldSerializeExitMacro() => !String.IsNullOrEmpty(ExitMacro);
  public bool ShouldSerializeHelpText() => HelpText is not null && ShouldSerialize(HelpText);
  public bool ShouldSerializeStatusText() => StatusText is not null && ShouldSerialize(StatusText);
  public bool ShouldSerializeCheckBox() => CheckBox is not null && ShouldSerialize(CheckBox);
  //public bool ShouldSerializeDropDownListFormField() => DropDownListFormField is not null && ShouldSerialize(DropDownListFormField);
  //public bool ShouldSerializeTextInput() => TextInput is not null && ShouldSerialize(TextInput);
}
