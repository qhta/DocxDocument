namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableRowHeight Class.
/// </summary>
public interface ITableRowHeight // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Table Row Height
  /// </summary>
  public UInt32? Val { get ; set; }
  
  /// <summary>
  /// Table Row Height Type
  /// </summary>
  public HeightRuleKind? HeightType { get ; set; }
  
}
