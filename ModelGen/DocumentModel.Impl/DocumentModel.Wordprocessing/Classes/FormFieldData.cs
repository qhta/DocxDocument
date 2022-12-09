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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<Boolean>? Enableds
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<Boolean>? CalculateOnExits
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<String>? EntryMacros
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<String>? ExitMacros
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<HelpText>? HelpTexts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<StatusText>? StatusTexts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<CheckBox>? CheckBoxs
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<DropDownListFormField>? DropDownListFormFields
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<TextInput>? TextInputs
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
