namespace DocumentModel.Spreadsheet;

/// <summary>
/// Dynamic Filter.
/// </summary>
public interface IDynamicFilter // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Dynamic filter type
  /// </summary>
  public DocumentModel.Spreadsheet.DynamicFilterKind? Type { get ; set; }
  
  /// <summary>
  /// Value
  /// </summary>
  public System.Double? Val { get ; set; }
  
  /// <summary>
  /// Max Value
  /// </summary>
  public System.Double? MaxVal { get ; set; }
  
  /// <summary>
  /// valIso, this property is only available in Office 2010 and later.
  /// </summary>
  public System.DateTime? ValIso { get ; set; }
  
  /// <summary>
  /// maxValIso, this property is only available in Office 2010 and later.
  /// </summary>
  public System.DateTime? MaxValIso { get ; set; }
  
}
