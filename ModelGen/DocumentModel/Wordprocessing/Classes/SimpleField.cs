namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the SimpleField Class.
/// </summary>
public partial class SimpleField
{
  
  /// <summary>
  ///   Field Codes
  /// </summary>
  public String? Instruction { get; set; }
  
  
  /// <summary>
  ///   Field Should Not Be Recalculated
  /// </summary>
  public Boolean? FieldLock { get; set; }
  
  
  /// <summary>
  ///   Field Result Invalidated
  /// </summary>
  public Boolean? Dirty { get; set; }
  
  
  /// <summary>
  ///   Custom Field Data.
  /// </summary>
  public String? FieldData { get; set; }
  
  public ElementCollection<IModelElement>? Items { get; set; }
  
}
