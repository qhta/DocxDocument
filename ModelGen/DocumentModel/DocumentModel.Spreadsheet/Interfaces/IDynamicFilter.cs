namespace DocumentModel.Spreadsheet;

/// <summary>
/// Dynamic Filter.
/// </summary>
public interface IDynamicFilter // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Dynamic filter type
  /// </summary>
  public DynamicFilterValues? Type { get ; set; }
  
  /// <summary>
  /// Value
  /// </summary>
  public double? Val { get ; set; }
  
  /// <summary>
  /// Max Value
  /// </summary>
  public double? MaxVal { get ; set; }
  
  /// <summary>
  /// valIso, this property is only available in Office 2010 and later.
  /// </summary>
  public DateTime? ValIso { get ; set; }
  
  /// <summary>
  /// maxValIso, this property is only available in Office 2010 and later.
  /// </summary>
  public DateTime? MaxValIso { get ; set; }
  
}
