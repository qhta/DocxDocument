namespace DocumentModel.Vml;


/// <summary>
///   Shape Handle.
/// </summary>
public partial class ShapeHandle
{
  
  /// <summary>
  ///   Handle Position
  /// </summary>
  [SchemaAttr("position")]
  public String? Position { get; set; }
  
  
  /// <summary>
  ///   Handle Polar Center
  /// </summary>
  [SchemaAttr("polar")]
  public String? Polar { get; set; }
  
  
  /// <summary>
  ///   Handle Coordinate Mapping
  /// </summary>
  [SchemaAttr("map")]
  public String? Map { get; set; }
  
  
  /// <summary>
  ///   Invert Handle's X Position
  /// </summary>
  [SchemaAttr("invx")]
  public Boolean? InvertX { get; set; }
  
  
  /// <summary>
  ///   Invert Handle's Y Position
  /// </summary>
  [SchemaAttr("invy")]
  public Boolean? InvertY { get; set; }
  
  
  /// <summary>
  ///   Handle Inversion Toggle
  /// </summary>
  [SchemaAttr("switch")]
  public Boolean? Switch { get; set; }
  
  
  /// <summary>
  ///   Handle X Position Range
  /// </summary>
  [SchemaAttr("xrange")]
  public String? XRange { get; set; }
  
  
  /// <summary>
  ///   Handle Y Position Range
  /// </summary>
  [SchemaAttr("yrange")]
  public String? YRange { get; set; }
  
  
  /// <summary>
  ///   Handle Polar Radius Range
  /// </summary>
  [SchemaAttr("radiusrange")]
  public String? RadiusRange { get; set; }
  
}
