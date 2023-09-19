namespace DocumentModel.Drawings;


/// <summary>
///   Defines the ForegroundMark Class.
/// </summary>
public partial class ForegroundMark
{
  
  /// <summary>
  ///   x1, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("x1")]
  public Int32? FirstXCoordinate { get; set; }
  
  
  /// <summary>
  ///   y1, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("y1")]
  public Int32? FirstYCoordinate { get; set; }
  
  
  /// <summary>
  ///   x2, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("x2")]
  public Int32? SecondXCoordinate { get; set; }
  
  
  /// <summary>
  ///   y2, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("y2")]
  public Int32? SecondYCoordinate { get; set; }
  
}
