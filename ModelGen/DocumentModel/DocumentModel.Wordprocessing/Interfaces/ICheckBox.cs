namespace DocumentModel.Wordprocessing;

/// <summary>
/// Checkbox Form Field Properties.
/// </summary>
public interface ICheckBox // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.String? FormFieldSize { get ; set; }
  
  public System.Boolean? AutomaticallySizeFormField { get ; set; }
  
  public System.Boolean? DefaultCheckBoxFormFieldState { get ; set; }
  
  public System.Boolean? Checked { get ; set; }
  
}
