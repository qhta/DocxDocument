namespace DocumentModel.Wordprocessing;

public partial class FormFieldData
{
  public bool ShouldSerializeFormFieldName() => FormFieldName is not null;
  public bool ShouldSerializeEnabled() => Enabled is not null;
  public bool ShouldSerializeCalculateOnExit() => CalculateOnExit is not null;
  public bool ShouldSerializeEntryMacro() => EntryMacro is not null;
  public bool ShouldSerializeExitMacro() => ExitMacro is not null;
  public bool ShouldSerializeHelpText() => HelpText is not null;
  public bool ShouldSerializeStatusText() => StatusText is not null;
  public bool ShouldSerializeCheckBox() => CheckBox is not null;
  public bool ShouldSerializeDropDownListFormField() => DropDownListFormField is not null;
  public bool ShouldSerializeTextInput() => TextInput is not null;
}
