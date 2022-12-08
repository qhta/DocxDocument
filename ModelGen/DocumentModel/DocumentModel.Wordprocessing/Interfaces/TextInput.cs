namespace DocumentModel.Wordprocessing;

/// <summary>
/// Text Box Form Field Properties.
/// </summary>
public interface TextInput
{
  /// <summary>
  /// Text Box Form Field Type.
  /// </summary>
  public TextBoxFormFieldKind? TextBoxFormFieldType { get ; set; }
  
  /// <summary>
  /// Default Text Box Form Field String.
  /// </summary>
  public String? DefaultTextBoxFormFieldString { get ; set; }
  
  /// <summary>
  /// Text Box Form Field Maximum Length.
  /// </summary>
  public Int16? MaxLength { get ; set; }
  
  /// <summary>
  /// Text Box Form Field Formatting.
  /// </summary>
  public String? Format { get ; set; }
  
}
