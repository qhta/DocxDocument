namespace DocumentModel.Wordprocessing;

/// <summary>
/// Form Field Properties.
/// </summary>
public class FormFieldDataImpl: ModelElementImpl, FormFieldData
{
  public DocumentFormat.OpenXml.Wordprocessing.FormFieldData? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.FormFieldData?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<String>? FormFieldNames
  {
    get;
    set;
  }
  
  public Collection<Boolean>? Enableds
  {
    get;
    set;
  }
  
  public Collection<Boolean>? CalculateOnExits
  {
    get;
    set;
  }
  
  public Collection<String>? EntryMacros
  {
    get;
    set;
  }
  
  public Collection<String>? ExitMacros
  {
    get;
    set;
  }
  
  public Collection<HelpText>? HelpTexts
  {
    get;
    set;
  }
  
  public Collection<StatusText>? StatusTexts
  {
    get;
    set;
  }
  
  public Collection<CheckBox>? CheckBoxs
  {
    get;
    set;
  }
  
  public Collection<DropDownListFormField>? DropDownListFormFields
  {
    get;
    set;
  }
  
  public Collection<TextInput>? TextInputs
  {
    get;
    set;
  }
  
}
