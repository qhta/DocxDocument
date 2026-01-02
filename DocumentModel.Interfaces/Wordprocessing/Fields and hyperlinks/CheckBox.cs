namespace DocumentModel.Wordprocessing;

/// <summary>
///   Checkbox Form Field Properties.
/// </summary>
public class CheckBox: ModelElement
{
  public string? FormFieldSize { get; set; }
  public bool? AutomaticallySizeFormField { get; set; }
  public bool? DefaultCheckBoxFormFieldState { get; set; }
  public bool? Checked { get; set; }
}