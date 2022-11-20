namespace DocumentModel.Presentation;

/// <summary>
/// Build OLE Chart.
/// </summary>
public class BuildOleChart: IBuildOleChart
{
  /// <summary>
  /// Shape ID
  /// </summary>
  public string? ShapeId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Group ID
  /// </summary>
  public uint? GroupId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Expand UI
  /// </summary>
  public bool? UiExpand
  {
    get;
    set;
  }
  
  /// <summary>
  /// Build
  /// </summary>
  public OleChartBuildValues? Build
  {
    get;
    set;
  }
  
  /// <summary>
  /// Animate Background
  /// </summary>
  public bool? AnimateBackground
  {
    get;
    set;
  }
  
}
