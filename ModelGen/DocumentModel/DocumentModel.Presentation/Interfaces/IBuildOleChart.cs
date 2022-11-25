namespace DocumentModel.Presentation;

/// <summary>
/// Build OLE Chart.
/// </summary>
public interface IBuildOleChart // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Shape ID
  /// </summary>
  public System.String? ShapeId { get ; set; }
  
  /// <summary>
  /// Group ID
  /// </summary>
  public System.UInt32? GroupId { get ; set; }
  
  /// <summary>
  /// Expand UI
  /// </summary>
  public System.Boolean? UiExpand { get ; set; }
  
  /// <summary>
  /// Build
  /// </summary>
  public DocumentModel.Presentation.OleChartBuildKind? Build { get ; set; }
  
  /// <summary>
  /// Animate Background
  /// </summary>
  public System.Boolean? AnimateBackground { get ; set; }
  
}
