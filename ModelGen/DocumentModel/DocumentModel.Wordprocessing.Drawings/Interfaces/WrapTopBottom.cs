namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Top and Bottom Wrapping.
/// </summary>
public interface WrapTopBottom
{
  /// <summary>
  /// Distance From Text on Top Edge
  /// </summary>
  public UInt32? DistanceFromTop { get ; set; }
  
  /// <summary>
  /// Distance From Text on Bottom Edge
  /// </summary>
  public UInt32? DistanceFromBottom { get ; set; }
  
  /// <summary>
  /// Wrapping Boundaries.
  /// </summary>
  public EffectExtent? EffectExtent { get ; set; }
  
}
