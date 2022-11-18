namespace DocumentModel.Presentation;

/// <summary>
/// OLE Chart Element.
/// </summary>
public interface IOleChartElement // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Type
  /// </summary>
  public ChartSubElement? Type { get ; set; }
  
  /// <summary>
  /// Level
  /// </summary>
  public uint? Level { get ; set; }
  
}
