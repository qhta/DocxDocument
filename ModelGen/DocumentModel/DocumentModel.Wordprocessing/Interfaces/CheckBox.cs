namespace DocumentModel.Wordprocessing;

/// <summary>
/// Checkbox Form Field Properties.
/// </summary>
public interface CheckBox // : DocumentModel.BaseTypes.ModelElement
{
  public String? FormFieldSize { get ; set; }
  
  public Boolean? AutomaticallySizeFormField { get ; set; }
  
  public Boolean? DefaultCheckBoxFormFieldState { get ; set; }
  
  public Boolean? Checked { get ; set; }
  
}
