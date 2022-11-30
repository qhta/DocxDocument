namespace DocumentModel.Spreadsheet;

/// <summary>
/// Date Time.
/// </summary>
public interface IDateTimeItem // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Value
  /// </summary>
  public System.DateTime? Val { get ; set; }
  
  /// <summary>
  /// Unused Item
  /// </summary>
  public System.Boolean? Unused { get ; set; }
  
  /// <summary>
  /// Calculated Item Value
  /// </summary>
  public System.Boolean? Calculated { get ; set; }
  
  /// <summary>
  /// Caption
  /// </summary>
  public System.String? Caption { get ; set; }
  
  /// <summary>
  /// Member Property Count
  /// </summary>
  public System.UInt32? PropertyCount { get ; set; }
  
  public System.Collections.ObjectModel.Collection<System.Int32>? MemberPropertyIndexs { get ; set; }
  
}
