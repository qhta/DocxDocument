namespace DocumentModel.Wordprocessing;


/// <summary>
///   Complex Field Character.
/// </summary>
public partial class FieldChar
{
  
  /// <summary>
  ///   Field Character Type
  /// </summary>
  public FieldCharKind? FieldCharType { get; set; }
  
  
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
  
  
  /// <summary>
  ///   Form Field Properties.
  /// </summary>
  public FormFieldData? FormFieldData { get; set; }
  
  
  /// <summary>
  ///   Previous Numbering Field Properties.
  /// </summary>
  public NumberingChange? NumberingChange { get; set; }
  
}
