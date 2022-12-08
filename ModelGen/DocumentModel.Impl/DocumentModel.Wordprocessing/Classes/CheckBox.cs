namespace DocumentModel.Wordprocessing;

/// <summary>
/// Checkbox Form Field Properties.
/// </summary>
public class CheckBoxImpl: ModelElementImpl, CheckBox
{
  public DocumentFormat.OpenXml.Wordprocessing.CheckBox? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.CheckBox?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public String? FormFieldSize
  {
    get;
    set;
  }
  
  public Boolean? AutomaticallySizeFormField
  {
    get;
    set;
  }
  
  public Boolean? DefaultCheckBoxFormFieldState
  {
    get;
    set;
  }
  
  public Boolean? Checked
  {
    get;
    set;
  }
  
}
