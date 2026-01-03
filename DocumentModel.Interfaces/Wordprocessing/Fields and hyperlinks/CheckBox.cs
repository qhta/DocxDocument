namespace DocumentModel.Wordprocessing;

/// <summary>
///   Checkbox Form Field Properties.
/// </summary>
public interface CheckBox: IModelElement
{
  public string? FormFieldSize { get; set; }
  public bool? AutomaticallySizeFormField { get; set; }
  public bool? DefaultCheckBoxFormFieldState { get; set; }
  public bool? Checked { get; set; }
}