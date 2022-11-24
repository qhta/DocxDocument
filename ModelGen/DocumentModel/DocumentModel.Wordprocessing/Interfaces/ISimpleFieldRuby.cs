namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SimpleFieldRuby Class.
/// </summary>
public interface ISimpleFieldRuby // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// instr
  /// </summary>
  public String? Instruction { get ; set; }
  
  /// <summary>
  /// fldLock
  /// </summary>
  public Boolean? FieldLock { get ; set; }
  
  /// <summary>
  /// dirty
  /// </summary>
  public Boolean? Dirty { get ; set; }
  
  /// <summary>
  /// FieldData.
  /// </summary>
  public IFieldData? FieldData { get ; set; }
  
}
