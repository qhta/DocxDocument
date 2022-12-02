namespace DocumentModel.Vml;

/// <summary>
/// Defines the Lock Class.
/// </summary>
public interface ILock // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public DocumentModel.Vml.ExtensionHandlingBehaviorKind? Extension { get ; set; }
  
  /// <summary>
  /// Position Lock
  /// </summary>
  public System.Boolean? Position { get ; set; }
  
  /// <summary>
  /// Selection Lock
  /// </summary>
  public System.Boolean? Selection { get ; set; }
  
  /// <summary>
  /// Grouping Lock
  /// </summary>
  public System.Boolean? Grouping { get ; set; }
  
  /// <summary>
  /// Ungrouping Lock
  /// </summary>
  public System.Boolean? Ungrouping { get ; set; }
  
  /// <summary>
  /// Rotation Lock
  /// </summary>
  public System.Boolean? Rotation { get ; set; }
  
  /// <summary>
  /// Cropping Lock
  /// </summary>
  public System.Boolean? Cropping { get ; set; }
  
  /// <summary>
  /// Vertices Lock
  /// </summary>
  public System.Boolean? Verticies { get ; set; }
  
  /// <summary>
  /// Handles Lock
  /// </summary>
  public System.Boolean? AdjustHandles { get ; set; }
  
  /// <summary>
  /// Text Lock
  /// </summary>
  public System.Boolean? TextLock { get ; set; }
  
  /// <summary>
  /// Aspect Ratio Lock
  /// </summary>
  public System.Boolean? AspectRatio { get ; set; }
  
  /// <summary>
  /// AutoShape Type Lock
  /// </summary>
  public System.Boolean? ShapeType { get ; set; }
  
}
