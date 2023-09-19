namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the SimpleFieldRuby Class.
/// </summary>
public partial class SimpleFieldRuby
{
  
  /// <summary>
  ///   instr
  /// </summary>
  [SchemaAttr("w:instr")]
  public String? Instruction { get; set; }
  
  
  /// <summary>
  ///   fldLock
  /// </summary>
  [SchemaAttr("w:fldLock")]
  public Boolean? FieldLock { get; set; }
  
  
  /// <summary>
  ///   dirty
  /// </summary>
  [SchemaAttr("w:dirty")]
  public Boolean? Dirty { get; set; }
  
  
  /// <summary>
  ///   FieldData.
  /// </summary>
  public String? FieldData { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.IModelElement>? Items { get; set; }
  
}
