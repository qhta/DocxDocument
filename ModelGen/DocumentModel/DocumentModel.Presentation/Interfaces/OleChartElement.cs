namespace DocumentModel.Presentation;

/// <summary>
/// OLE Chart Element.
/// </summary>
public interface OleChartElement // : System.Boolean
{
  /// <summary>
  /// Type
  /// </summary>
  public ChartSubElementKind? Type { get ; set; }
  
  /// <summary>
  /// Level
  /// </summary>
  public UInt32? Level { get ; set; }
  
}
