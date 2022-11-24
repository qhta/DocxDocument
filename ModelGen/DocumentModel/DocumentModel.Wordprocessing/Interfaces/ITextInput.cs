namespace DocumentModel.Wordprocessing;

/// <summary>
/// Text Box Form Field Properties.
/// </summary>
public interface ITextInput // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Text Box Form Field Type.
  /// </summary>
  public IEnumValue<DocumentFormat.OpenXml.Wordprocessing.TextBoxFormFieldValues>? TextBoxFormFieldType { get ; set; }
  
  /// <summary>
  /// Default Text Box Form Field String.
  /// </summary>
  public IDefaultTextBoxFormFieldString? DefaultTextBoxFormFieldString { get ; set; }
  
  /// <summary>
  /// Text Box Form Field Maximum Length.
  /// </summary>
  public Int16Value? MaxLength { get ; set; }
  
  /// <summary>
  /// Text Box Form Field Formatting.
  /// </summary>
  public IStringValue? Format { get ; set; }
  
}
