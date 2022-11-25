namespace DocumentModel.Presentation;

/// <summary>
/// OLE Chart Element.
/// </summary>
public interface IOleChartElement // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Type
  /// </summary>
  public DocumentModel.Presentation.ChartSubElementKind? Type { get ; set; }
  
  /// <summary>
  /// Level
  /// </summary>
  public System.UInt32? Level { get ; set; }
  
}
