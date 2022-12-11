namespace DocumentModel.Wordprocessing;

/// <summary>
/// Form Field Properties.
/// </summary>
public interface FormFieldData
{
  public String? FormFieldName { get ; set; }
  
  public Boolean? Enabled { get ; set; }
  
  public Boolean? CalculateOnExit { get ; set; }
  
  public String? EntryMacro { get ; set; }
  
  public String? ExitMacro { get ; set; }
  
  public HelpText? HelpText { get ; set; }
  
  public StatusText? StatusText { get ; set; }
  
  public CheckBox? CheckBox { get ; set; }
  
  public DropDownListFormField? DropDownListFormField { get ; set; }
  
  public TextInput? TextInput { get ; set; }
  
}
