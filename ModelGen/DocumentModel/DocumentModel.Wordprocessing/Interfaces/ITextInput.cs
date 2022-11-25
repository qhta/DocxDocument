namespace DocumentModel.Wordprocessing;

/// <summary>
/// Text Box Form Field Properties.
/// </summary>
public interface ITextInput // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Text Box Form Field Type.
  /// </summary>
  public DocumentModel.Wordprocessing.TextBoxFormFieldKind? TextBoxFormFieldType { get ; set; }
  
  /// <summary>
  /// Default Text Box Form Field String.
  /// </summary>
  public System.String? DefaultTextBoxFormFieldString { get ; set; }
  
  /// <summary>
  /// Text Box Form Field Maximum Length.
  /// </summary>
  public System.Int16? MaxLength { get ; set; }
  
  /// <summary>
  /// Text Box Form Field Formatting.
  /// </summary>
  public System.String? Format { get ; set; }
  
}
