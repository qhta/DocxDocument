namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Object Extents Including Effects.
/// </summary>
public partial class EffectExtent
{
  
  /// <summary>
  ///   Additional Extent on Left Edge
  /// </summary>
  [SchemaAttr("l")]
  public Int64? LeftEdge { get; set; }
  
  
  /// <summary>
  ///   Additional Extent on Top Edge
  /// </summary>
  [SchemaAttr("t")]
  public Int64? TopEdge { get; set; }
  
  
  /// <summary>
  ///   Additional Extent on Right Edge
  /// </summary>
  [SchemaAttr("r")]
  public Int64? RightEdge { get; set; }
  
  
  /// <summary>
  ///   Additional Extent on Bottom Edge
  /// </summary>
  [SchemaAttr("b")]
  public Int64? BottomEdge { get; set; }
  
}
