namespace DocumentModel.Spreadsheet;

/// <summary>
/// Date Time.
/// </summary>
public interface IDateTimeItem // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Value
  /// </summary>
  public DateTime? Val { get ; set; }
  
  /// <summary>
  /// Unused Item
  /// </summary>
  public Boolean? Unused { get ; set; }
  
  /// <summary>
  /// Calculated Item Value
  /// </summary>
  public Boolean? Calculated { get ; set; }
  
  /// <summary>
  /// Caption
  /// </summary>
  public String? Caption { get ; set; }
  
  /// <summary>
  /// Member Property Count
  /// </summary>
  public UInt32? PropertyCount { get ; set; }
  
  public Collection<Int32>? MemberPropertyIndexs { get ; set; }
  
}
