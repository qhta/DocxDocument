namespace DocumentModel.Spreadsheet;

/// <summary>
/// Dynamic Filter.
/// </summary>
public interface IDynamicFilter // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Dynamic filter type
  /// </summary>
  public DynamicFilterKind? Type { get ; set; }
  
  /// <summary>
  /// Value
  /// </summary>
  public Double? Val { get ; set; }
  
  /// <summary>
  /// Max Value
  /// </summary>
  public Double? MaxVal { get ; set; }
  
  /// <summary>
  /// valIso, this property is only available in Office 2010 and later.
  /// </summary>
  public DateTime? ValIso { get ; set; }
  
  /// <summary>
  /// maxValIso, this property is only available in Office 2010 and later.
  /// </summary>
  public DateTime? MaxValIso { get ; set; }
  
}
