namespace DocumentModel.Wordprocessing;

/// <summary>
/// Form Field Properties.
/// </summary>
public partial class FormFieldData
{
  public String? FormFieldName { get; set; }
  
  public Boolean? Enabled { get; set; }
  
  public Boolean? CalculateOnExit { get; set; }
  
  public String? EntryMacro { get; set; }
  
  public String? ExitMacro { get; set; }
  
  public DocumentModel.Wordprocessing.HelpText? HelpText { get; set; }
  
  public DocumentModel.Wordprocessing.StatusText? StatusText { get; set; }
  
  public DocumentModel.Wordprocessing.CheckBox? CheckBox { get; set; }
  
  public DocumentModel.Wordprocessing.DropDownListFormField? DropDownListFormField { get; set; }
  
  public DocumentModel.Wordprocessing.TextInput? TextInput { get; set; }
  
}
