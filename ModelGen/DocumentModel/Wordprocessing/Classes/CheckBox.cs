namespace DocumentModel.Wordprocessing;


/// <summary>
///   Checkbox Form Field Properties.
/// </summary>
public partial class CheckBox
{
  public DocumentModel.Wordprocessing.FormFieldSize? FormFieldSize { get; set; }
  
  public DocumentModel.Wordprocessing.AutomaticallySizeFormField? AutomaticallySizeFormField { get; set; }
  
  public DocumentModel.Wordprocessing.DefaultCheckBoxFormFieldState? DefaultCheckBoxFormFieldState { get; set; }
  
  public DocumentModel.Wordprocessing.Checked? Checked { get; set; }
  
}
