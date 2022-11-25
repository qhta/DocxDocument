namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SimpleFieldRuby Class.
/// </summary>
public interface ISimpleFieldRuby // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// instr
  /// </summary>
  public System.String? Instruction { get ; set; }
  
  /// <summary>
  /// fldLock
  /// </summary>
  public System.Boolean? FieldLock { get ; set; }
  
  /// <summary>
  /// dirty
  /// </summary>
  public System.Boolean? Dirty { get ; set; }
  
  /// <summary>
  /// FieldData.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? FieldData { get ; set; }
  
}
