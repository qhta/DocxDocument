namespace DocumentModel.Wordprocessing;

/// <summary>
/// Complex Field Character.
/// </summary>
public interface FieldChar
{
  /// <summary>
  /// Field Character Type
  /// </summary>
  public FieldCharKind? FieldCharType { get ; set; }
  
  /// <summary>
  /// Form Field Properties.
  /// </summary>
  public FormFieldData? FormFieldData { get ; set; }
  
  /// <summary>
  /// Previous Numbering Field Properties.
  /// </summary>
  public NumberingChange? NumberingChange { get ; set; }
  
}
