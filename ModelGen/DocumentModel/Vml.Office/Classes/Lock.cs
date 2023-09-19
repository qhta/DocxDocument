namespace DocumentModel.Vml.Office;


/// <summary>
///   Defines the Lock Class.
/// </summary>
public partial class Lock
{
  
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  [SchemaAttr("v:ext")]
  public DocumentModel.Vml.ExtensionHandlingBehaviorValues? Extension { get; set; }
  
  
  /// <summary>
  ///   Position Lock
  /// </summary>
  [SchemaAttr("position")]
  public Boolean? Position { get; set; }
  
  
  /// <summary>
  ///   Selection Lock
  /// </summary>
  [SchemaAttr("selection")]
  public Boolean? Selection { get; set; }
  
  
  /// <summary>
  ///   Grouping Lock
  /// </summary>
  [SchemaAttr("grouping")]
  public Boolean? Grouping { get; set; }
  
  
  /// <summary>
  ///   Ungrouping Lock
  /// </summary>
  [SchemaAttr("ungrouping")]
  public Boolean? Ungrouping { get; set; }
  
  
  /// <summary>
  ///   Rotation Lock
  /// </summary>
  [SchemaAttr("rotation")]
  public Boolean? Rotation { get; set; }
  
  
  /// <summary>
  ///   Cropping Lock
  /// </summary>
  [SchemaAttr("cropping")]
  public Boolean? Cropping { get; set; }
  
  
  /// <summary>
  ///   Vertices Lock
  /// </summary>
  [SchemaAttr("verticies")]
  public Boolean? Verticies { get; set; }
  
  
  /// <summary>
  ///   Handles Lock
  /// </summary>
  [SchemaAttr("adjusthandles")]
  public Boolean? AdjustHandles { get; set; }
  
  
  /// <summary>
  ///   Text Lock
  /// </summary>
  [SchemaAttr("text")]
  public Boolean? TextLock { get; set; }
  
  
  /// <summary>
  ///   Aspect Ratio Lock
  /// </summary>
  [SchemaAttr("aspectratio")]
  public Boolean? AspectRatio { get; set; }
  
  
  /// <summary>
  ///   AutoShape Type Lock
  /// </summary>
  [SchemaAttr("shapetype")]
  public Boolean? ShapeType { get; set; }
  
}
