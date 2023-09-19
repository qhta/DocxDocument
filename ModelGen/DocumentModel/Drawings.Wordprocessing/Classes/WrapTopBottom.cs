namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Top and Bottom Wrapping.
/// </summary>
public partial class WrapTopBottom
{
  
  /// <summary>
  ///   Distance From Text on Top Edge
  /// </summary>
  [SchemaAttr("distT")]
  public UInt32? DistanceFromTop { get; set; }
  
  
  /// <summary>
  ///   Distance From Text on Bottom Edge
  /// </summary>
  [SchemaAttr("distB")]
  public UInt32? DistanceFromBottom { get; set; }
  
  
  /// <summary>
  ///   Wrapping Boundaries.
  /// </summary>
  public DocumentModel.Drawings.Wordprocessing.EffectExtent? EffectExtent { get; set; }
  
}
