namespace DocumentModel.Vml.Office;


/// <summary>
///   Defines the Lock Class.
/// </summary>
public partial class Lock
{
  
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public DocumentModel.Vml.ExtensionHandlingBehaviorKind? Extension { get; set; }
  
  
  /// <summary>
  ///   Position Lock
  /// </summary>
  public DM.TrueFalseValue? Position { get; set; }
  
  
  /// <summary>
  ///   Selection Lock
  /// </summary>
  public DM.TrueFalseValue? Selection { get; set; }
  
  
  /// <summary>
  ///   Grouping Lock
  /// </summary>
  public DM.TrueFalseValue? Grouping { get; set; }
  
  
  /// <summary>
  ///   Ungrouping Lock
  /// </summary>
  public DM.TrueFalseValue? Ungrouping { get; set; }
  
  
  /// <summary>
  ///   Rotation Lock
  /// </summary>
  public DM.TrueFalseValue? Rotation { get; set; }
  
  
  /// <summary>
  ///   Cropping Lock
  /// </summary>
  public DM.TrueFalseValue? Cropping { get; set; }
  
  
  /// <summary>
  ///   Vertices Lock
  /// </summary>
  public DM.TrueFalseValue? Verticies { get; set; }
  
  
  /// <summary>
  ///   Handles Lock
  /// </summary>
  public DM.TrueFalseValue? AdjustHandles { get; set; }
  
  
  /// <summary>
  ///   Text Lock
  /// </summary>
  public DM.TrueFalseValue? TextLock { get; set; }
  
  
  /// <summary>
  ///   Aspect Ratio Lock
  /// </summary>
  public DM.TrueFalseValue? AspectRatio { get; set; }
  
  
  /// <summary>
  ///   AutoShape Type Lock
  /// </summary>
  public DM.TrueFalseValue? ShapeType { get; set; }
  
}
