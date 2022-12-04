namespace DocumentModel.Vml;

/// <summary>
/// 3D Extrusion.
/// </summary>
public class Extrusion
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension
  {
    get;
    set;
  }
  
  /// <summary>
  /// Extrusion Type
  /// </summary>
  public ExtrusionKind? Type
  {
    get;
    set;
  }
  
  /// <summary>
  /// Extrusion Render Mode
  /// </summary>
  public ExtrusionRenderKind? Render
  {
    get;
    set;
  }
  
}
