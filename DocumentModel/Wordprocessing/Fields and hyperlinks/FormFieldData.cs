namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Form Field Properties.
/// </summary>
public class FormFieldData: ModelElement
{
  public string? FormFieldName { get; set; }

  public bool? Enabled { get; set; }

  public bool? CalculateOnExit { get; set; }

  public string? EntryMacro { get; set; }

  public string? ExitMacro { get; set; }

  public HelpText? HelpText { get; set; }

  public StatusText? StatusText { get; set; }

  public CheckBox? CheckBox { get; set; }

  public DropDownListFormField? DropDownListFormField { get; set; }

  public TextInput? TextInput { get; set; }
}