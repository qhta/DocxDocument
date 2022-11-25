namespace DocumentModel.Presentation;

/// <summary>
/// Build Diagram.
/// </summary>
public interface IBuildDiagram // : DocumentModel.ITypedOpenXmlLeafElement
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
  /// Diagram Build Types
  /// </summary>
  public DocumentModel.Presentation.DiagramBuildKind? Build { get ; set; }
  
}
