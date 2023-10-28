namespace DocumentModel.Vml;


/// <summary>
///   Shape Layout Properties.
/// </summary>
public partial class ShapeLayout
{
  
  /// <summary>
  ///   Shape ID Map.
  /// </summary>
  public DMVML.ShapeIdMap? ShapeIdMap { get; set; }
  
  
  /// <summary>
  ///   Shape Grouping History.
  /// </summary>
  public DMVML.RegroupTable? RegroupTable { get; set; }
  
  
  /// <summary>
  ///   Rule Set.
  /// </summary>
  public DMVML.Rules? Rules { get; set; }
  
}
