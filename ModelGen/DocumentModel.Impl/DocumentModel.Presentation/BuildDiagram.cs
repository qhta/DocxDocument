namespace DocumentModel.Presentation;

/// <summary>
/// Build Diagram.
/// </summary>
public class BuildDiagram: IBuildDiagram
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
  /// Diagram Build Types
  /// </summary>
  public DiagramBuildValues? Build
  {
    get;
    set;
  }
  
}
