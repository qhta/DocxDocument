namespace DocumentModel.Wordprocessing;


/// <summary>
///   Complex Field Character.
/// </summary>
public partial class FieldChar
{
  
  /// <summary>
  ///   Field Character Type
  /// </summary>
  [SchemaAttr("w:fldCharType")]
  public DocumentModel.Wordprocessing.FieldCharValues? FieldCharType { get; set; }
  
  
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
  
  
  /// <summary>
  ///   Form Field Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.FormFieldData? FormFieldData { get; set; }
  
  
  /// <summary>
  ///   Previous Numbering Field Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.NumberingChange? NumberingChange { get; set; }
  
}
