namespace DocumentModel.Spreadsheet;

/// <summary>
/// Boolean.
/// </summary>
public interface BooleanItem // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Value
  /// </summary>
  public Boolean? Val { get ; set; }
  
  /// <summary>
  /// Unused Item
  /// </summary>
  public Boolean? Unused { get ; set; }
  
  /// <summary>
  /// Calculated Item
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
