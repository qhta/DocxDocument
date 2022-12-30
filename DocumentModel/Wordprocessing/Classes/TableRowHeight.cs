namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableRowHeight Class.
/// </summary>
public partial class TableRowHeight
{
  /// <summary>
  /// Table Row Height
  /// </summary>
  public UInt32? Val { get; set; }
  
  /// <summary>
  /// Table Row Height Type
  /// </summary>
  public DocumentModel.Wordprocessing.HeightRuleKind? HeightType { get; set; }
  
}
