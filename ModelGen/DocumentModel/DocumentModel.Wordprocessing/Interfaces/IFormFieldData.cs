namespace DocumentModel.Wordprocessing;

/// <summary>
/// Form Field Properties.
/// </summary>
public interface IFormFieldData // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.String? FormFieldName { get ; set; }
  
  public System.Boolean? Enabled { get ; set; }
  
  public System.Boolean? CalculateOnExit { get ; set; }
  
  public System.String? EntryMacro { get ; set; }
  
  public System.String? ExitMacro { get ; set; }
  
  public DocumentModel.Wordprocessing.IHelpText? HelpText { get ; set; }
  
  public DocumentModel.Wordprocessing.IStatusText? StatusText { get ; set; }
  
  public DocumentModel.Wordprocessing.ICheckBox? CheckBox { get ; set; }
  
  public DocumentModel.Wordprocessing.IDropDownListFormField? DropDownListFormField { get ; set; }
  
  public DocumentModel.Wordprocessing.ITextInput? TextInput { get ; set; }
  
}
