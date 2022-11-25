namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SimpleField Class.
/// </summary>
public interface ISimpleField // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Field Codes
  /// </summary>
  public System.String? Instruction { get ; set; }
  
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
  public DocumentModel.BaseTypes.ModelElement? FieldData { get ; set; }
  
}
