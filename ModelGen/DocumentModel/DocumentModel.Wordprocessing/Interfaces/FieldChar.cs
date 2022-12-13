namespace DocumentModel.Wordprocessing;

/// <summary>
/// Complex Field Character.
/// </summary>
public interface FieldChar
{
  /// <summary>
  /// Field Character Type
  /// </summary>
  public DocumentModel.Wordprocessing.FieldCharKind? FieldCharType { get ; set; }
  
  /// <summary>
  /// Field Should Not Be Recalculated
  /// </summary>
  public Boolean? FieldLock { get ; set; }
  
  /// <summary>
  /// Field Result Invalidated
  /// </summary>
  public Boolean? Dirty { get ; set; }
  
  /// <summary>
  /// Custom Field Data.
  /// </summary>
  public String? FieldData { get ; set; }
  
  /// <summary>
  /// Form Field Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.FormFieldData? FormFieldData { get ; set; }
  
  /// <summary>
  /// Previous Numbering Field Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.NumberingChange? NumberingChange { get ; set; }
  
}
