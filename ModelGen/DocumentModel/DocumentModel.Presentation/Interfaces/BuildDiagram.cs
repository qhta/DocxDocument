namespace DocumentModel.Presentation;

/// <summary>
/// Build Diagram.
/// </summary>
public interface BuildDiagram // : System.Boolean
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
  public DiagramBuildKind? Build { get ; set; }
  
}
