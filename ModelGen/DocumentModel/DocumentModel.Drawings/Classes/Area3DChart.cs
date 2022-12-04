namespace DocumentModel.Drawings;

/// <summary>
/// 3D Area Charts.
/// </summary>
public class Area3DChart
{
  /// <summary>
  /// Grouping.
  /// </summary>
  public GroupingKind? Grouping
  {
    get;
    set;
  }
  
  public DataLabels1? DataLabels
  {
    get;
    set;
  }
  
  public DropLines? DropLines
  {
    get;
    set;
  }
  
  public Area3DChartExtensionList? Area3DChartExtensionList
  {
    get;
    set;
  }
  
}
