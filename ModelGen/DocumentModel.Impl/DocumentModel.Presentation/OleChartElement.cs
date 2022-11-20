namespace DocumentModel.Presentation;

/// <summary>
/// OLE Chart Element.
/// </summary>
public class OleChartElement: IOleChartElement
{
  /// <summary>
  /// Type
  /// </summary>
  public ChartSubElementValues? Type
  {
    get;
    set;
  }
  
  /// <summary>
  /// Level
  /// </summary>
  public uint? Level
  {
    get;
    set;
  }
  
}
