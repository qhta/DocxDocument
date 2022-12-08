namespace DocumentModel.Wordprocessing;

/// <summary>
/// Form Field Properties.
/// </summary>
public interface FormFieldData
{
  public Collection<String>? FormFieldNames { get ; set; }
  
  public Collection<Boolean>? Enableds { get ; set; }
  
  public Collection<Boolean>? CalculateOnExits { get ; set; }
  
  public Collection<String>? EntryMacros { get ; set; }
  
  public Collection<String>? ExitMacros { get ; set; }
  
  public Collection<HelpText>? HelpTexts { get ; set; }
  
  public Collection<StatusText>? StatusTexts { get ; set; }
  
  public Collection<CheckBox>? CheckBoxs { get ; set; }
  
  public Collection<DropDownListFormField>? DropDownListFormFields { get ; set; }
  
  public Collection<TextInput>? TextInputs { get ; set; }
  
}
