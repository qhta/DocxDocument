namespace DocumentModel.Presentation;

/// <summary>
/// Build Diagram.
/// </summary>
public interface IBuildDiagram // : DocumentModel.ITypedOpenXmlLeafElement
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
  /// Diagram Build Types
  /// </summary>
  public DiagramBuildValues? Build { get ; set; }
  
}
