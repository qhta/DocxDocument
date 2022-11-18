namespace DocumentModel.Wordprocessing;

/// <summary>
/// Text Box Form Field Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITextBoxFormFieldType))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IMaxLength))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDefaultTextBoxFormFieldString))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IFormat))]
public interface ITextInput // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Text Box Form Field Type.
  /// </summary>
  public ITextBoxFormFieldType? TextBoxFormFieldType { get ; set; }
  
  /// <summary>
  /// Default Text Box Form Field String.
  /// </summary>
  public IDefaultTextBoxFormFieldString? DefaultTextBoxFormFieldString { get ; set; }
  
  /// <summary>
  /// Text Box Form Field Maximum Length.
  /// </summary>
  public IMaxLength? MaxLength { get ; set; }
  
  /// <summary>
  /// Text Box Form Field Formatting.
  /// </summary>
  public DocumentModel.Wordprocessing.IFormat? Format { get ; set; }
  
}
