namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Top and Bottom Wrapping.
/// </summary>
public partial class WrapTopBottom
{
  
  /// <summary>
  ///   Distance From Text on Top Edge
  /// </summary>
  public UInt32? DistanceFromTop { get; set; }
  
  
  /// <summary>
  ///   Distance From Text on Bottom Edge
  /// </summary>
  public UInt32? DistanceFromBottom { get; set; }
  
  
  /// <summary>
  ///   Wrapping Boundaries.
  /// </summary>
  public DMDW.EffectExtent? EffectExtent { get; set; }
  
}
