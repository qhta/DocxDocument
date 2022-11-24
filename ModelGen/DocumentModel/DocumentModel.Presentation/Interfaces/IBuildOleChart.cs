namespace DocumentModel.Presentation;

/// <summary>
/// Build OLE Chart.
/// </summary>
public interface IBuildOleChart // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Shape ID
  /// </summary>
  public String? ShapeId { get ; set; }
  
  /// <summary>
  /// Group ID
  /// </summary>
  public UInt32? GroupId { get ; set; }
  
  /// <summary>
  /// Expand UI
  /// </summary>
  public Boolean? UiExpand { get ; set; }
  
  /// <summary>
  /// Build
  /// </summary>
  public OleChartBuildValues? Build { get ; set; }
  
  /// <summary>
  /// Animate Background
  /// </summary>
  public Boolean? AnimateBackground { get ; set; }
  
}
