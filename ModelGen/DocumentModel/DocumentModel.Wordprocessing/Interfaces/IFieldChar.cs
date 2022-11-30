namespace DocumentModel.Wordprocessing;

/// <summary>
/// Complex Field Character.
/// </summary>
public interface IFieldChar // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Field Character Type
  /// </summary>
  public DocumentModel.Wordprocessing.FieldCharKind? FieldCharType { get ; set; }
  
  /// <summary>
  /// Field Should Not Be Recalculated
  /// </summary>
  public System.Boolean? FieldLock { get ; set; }
  
  /// <summary>
  /// Field Result Invalidated
  /// </summary>
  public System.Boolean? Dirty { get ; set; }
  
  /// <summary>
  /// Custom Field Data.
  /// </summary>
  public System.String? FieldData { get ; set; }
  
  /// <summary>
  /// Form Field Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.IFormFieldData? FormFieldData { get ; set; }
  
  /// <summary>
  /// Previous Numbering Field Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.INumberingChange? NumberingChange { get ; set; }
  
}
