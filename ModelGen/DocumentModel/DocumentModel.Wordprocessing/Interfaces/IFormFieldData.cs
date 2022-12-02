namespace DocumentModel.Wordprocessing;

/// <summary>
/// Form Field Properties.
/// </summary>
public interface IFormFieldData // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<String>? FormFieldNames { get ; set; }
  
  public Collection<Boolean>? Enableds { get ; set; }
  
  public Collection<Boolean>? CalculateOnExits { get ; set; }
  
  public Collection<String>? EntryMacros { get ; set; }
  
  public Collection<String>? ExitMacros { get ; set; }
  
  public Collection<IHelpText>? HelpTexts { get ; set; }
  
  public Collection<IStatusText>? StatusTexts { get ; set; }
  
  public Collection<ICheckBox>? CheckBoxs { get ; set; }
  
  public Collection<IDropDownListFormField>? DropDownListFormFields { get ; set; }
  
  public Collection<ITextInput>? TextInputs { get ; set; }
  
}
