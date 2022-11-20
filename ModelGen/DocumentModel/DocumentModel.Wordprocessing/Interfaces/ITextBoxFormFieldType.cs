namespace DocumentModel.Wordprocessing;

/// <summary>
/// Text Box Form Field Type.
/// </summary>
public interface ITextBoxFormFieldType // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Text Box Form Field Type Values
  /// </summary>
  public TextBoxFormFieldValues? Val { get ; set; }
  
}
