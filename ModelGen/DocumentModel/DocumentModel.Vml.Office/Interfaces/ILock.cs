namespace DocumentModel.Vml.Office;

/// <summary>
/// Defines the Lock Class.
/// </summary>
public interface ILock // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorValues? Extension { get ; set; }
  
  /// <summary>
  /// Position Lock
  /// </summary>
  public ITrueFalseValue? Position { get ; set; }
  
  /// <summary>
  /// Selection Lock
  /// </summary>
  public ITrueFalseValue? Selection { get ; set; }
  
  /// <summary>
  /// Grouping Lock
  /// </summary>
  public ITrueFalseValue? Grouping { get ; set; }
  
  /// <summary>
  /// Ungrouping Lock
  /// </summary>
  public ITrueFalseValue? Ungrouping { get ; set; }
  
  /// <summary>
  /// Rotation Lock
  /// </summary>
  public ITrueFalseValue? Rotation { get ; set; }
  
  /// <summary>
  /// Cropping Lock
  /// </summary>
  public ITrueFalseValue? Cropping { get ; set; }
  
  /// <summary>
  /// Vertices Lock
  /// </summary>
  public ITrueFalseValue? Verticies { get ; set; }
  
  /// <summary>
  /// Handles Lock
  /// </summary>
  public ITrueFalseValue? AdjustHandles { get ; set; }
  
  /// <summary>
  /// Text Lock
  /// </summary>
  public ITrueFalseValue? TextLock { get ; set; }
  
  /// <summary>
  /// Aspect Ratio Lock
  /// </summary>
  public ITrueFalseValue? AspectRatio { get ; set; }
  
  /// <summary>
  /// AutoShape Type Lock
  /// </summary>
  public ITrueFalseValue? ShapeType { get ; set; }
  
}
