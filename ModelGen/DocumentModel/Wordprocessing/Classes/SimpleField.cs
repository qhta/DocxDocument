namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the SimpleField Class.
/// </summary>
public partial class SimpleField
{
  
  /// <summary>
  ///   Field Codes
  /// </summary>
  [SchemaAttr("w:instr")]
  public String? Instruction { get; set; }
  
  
  /// <summary>
  ///   Field Should Not Be Recalculated
  /// </summary>
  [SchemaAttr("w:fldLock")]
  public Boolean? FieldLock { get; set; }
  
  
  /// <summary>
  ///   Field Result Invalidated
  /// </summary>
  [SchemaAttr("w:dirty")]
  public Boolean? Dirty { get; set; }
  
  
  /// <summary>
  ///   Custom Field Data.
  /// </summary>
  public String? FieldData { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.IModelElement>? Items { get; set; }
  
}
