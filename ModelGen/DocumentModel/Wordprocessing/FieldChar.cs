namespace DocumentModel.Wordprocessing;


/// <summary>
///   Complex Field Character.
/// </summary>
public partial class FieldChar
{
  
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
  public DMW.FieldData? FieldData { get; set; }
  
  
  /// <summary>
  ///   Form Field Properties.
  /// </summary>
  public DMW.FormFieldData? FormFieldData { get; set; }
  
  
  /// <summary>
  ///   Previous Numbering Field Properties.
  /// </summary>
  public DMW.NumberingChange? NumberingChange { get; set; }
  
}
