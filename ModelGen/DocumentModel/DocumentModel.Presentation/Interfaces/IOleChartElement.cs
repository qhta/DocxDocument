namespace DocumentModel.Presentation;

/// <summary>
/// OLE Chart Element.
/// </summary>
public interface IOleChartElement // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Type
  /// </summary>
  public ChartSubElementValues? Type { get ; set; }
  
  /// <summary>
  /// Level
  /// </summary>
  public UInt32? Level { get ; set; }
  
}
