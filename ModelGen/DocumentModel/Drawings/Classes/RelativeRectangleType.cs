namespace DocumentModel.Drawings;


/// <summary>
///   Defines the RelativeRectangleType Class.
/// </summary>
public partial class RelativeRectangleType
{
  
  /// <summary>
  ///   Left Offset
  /// </summary>
  [SchemaAttr("l")]
  public Int32? Left { get; set; }
  
  
  /// <summary>
  ///   Top Offset
  /// </summary>
  [SchemaAttr("t")]
  public Int32? Top { get; set; }
  
  
  /// <summary>
  ///   Right Offset
  /// </summary>
  [SchemaAttr("r")]
  public Int32? Right { get; set; }
  
  
  /// <summary>
  ///   Bottom Offset
  /// </summary>
  [SchemaAttr("b")]
  public Int32? Bottom { get; set; }
  
}
