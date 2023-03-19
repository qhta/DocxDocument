namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the TableRowHeight Class.
/// </summary>
public class TableRowHeight: ModelElement
{
  /// <summary>
  ///   Table Row Height
  /// </summary>
  public UInt32? Val { get; set; }

  /// <summary>
  ///   Table Row Height Type
  /// </summary>
  public HeightRuleKind? HeightType { get; set; }
}