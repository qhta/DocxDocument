namespace DocumentModel.Wordprocessing;

/// <summary>
/// Complex Field Character.
/// </summary>
public interface IFieldChar // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Field Character Type
  /// </summary>
  public FieldCharKind? FieldCharType { get ; set; }
  
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
  public IFieldData? FieldData { get ; set; }
  
  /// <summary>
  /// Form Field Properties.
  /// </summary>
  public IFormFieldData? FormFieldData { get ; set; }
  
  /// <summary>
  /// Previous Numbering Field Properties.
  /// </summary>
  public INumberingChange? NumberingChange { get ; set; }
  
}
