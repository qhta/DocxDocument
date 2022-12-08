namespace DocumentModel.Wordprocessing;

/// <summary>
/// Drop-Down List Form Field Properties.
/// </summary>
public class DropDownListFormFieldImpl: ModelElementImpl, DropDownListFormField
{
  public DocumentFormat.OpenXml.Wordprocessing.DropDownListFormField? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.DropDownListFormField?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Drop-Down List Selection.
  /// </summary>
  public Int32? DropDownListSelection
  {
    get;
    set;
  }
  
  /// <summary>
  /// Default Drop-Down List Item Index.
  /// </summary>
  public Int32? DefaultDropDownListItemIndex
  {
    get;
    set;
  }
  
  public Collection<String>? ListEntryFormFields
  {
    get;
    set;
  }
  
}
