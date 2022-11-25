namespace DocumentModel.Spreadsheet;

/// <summary>
/// Boolean.
/// </summary>
public interface IBooleanItem // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Value
  /// </summary>
  public System.Boolean? Val { get ; set; }
  
  /// <summary>
  /// Unused Item
  /// </summary>
  public System.Boolean? Unused { get ; set; }
  
  /// <summary>
  /// Calculated Item
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
  
}
