namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Chart Class.
/// </summary>
public class Chart1
{
  /// <summary>
  /// Title data and formatting.
  /// </summary>
  public Title2? Title
  {
    get;
    set;
  }
  
  /// <summary>
  /// pivot chart format persistence data.
  /// </summary>
  public PivotFormats? PivotFormats
  {
    get;
    set;
  }
  
  /// <summary>
  /// 3D view settings.
  /// </summary>
  public View3D? View3D
  {
    get;
    set;
  }
  
  /// <summary>
  /// 3D floor formatting.
  /// </summary>
  public Floor1? Floor
  {
    get;
    set;
  }
  
  /// <summary>
  /// 3D side wall formatting.
  /// </summary>
  public SideWall? SideWall
  {
    get;
    set;
  }
  
  /// <summary>
  /// 3D back wall formatting.
  /// </summary>
  public BackWall? BackWall
  {
    get;
    set;
  }
  
  /// <summary>
  /// Plot data and formatting.
  /// </summary>
  public PlotArea1? PlotArea
  {
    get;
    set;
  }
  
  /// <summary>
  /// Legend data and formatting.
  /// </summary>
  public Legend1? Legend
  {
    get;
    set;
  }
  
  /// <summary>
  /// The way that blank cells are plotted on a chart..
  /// </summary>
  public DisplayBlanksAsKind? DisplayBlanksAs
  {
    get;
    set;
  }
  
  /// <summary>
  /// Extensibility container.
  /// </summary>
  public ChartExtensionList? ChartExtensionList
  {
    get;
    set;
  }
  
}
