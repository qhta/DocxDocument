namespace DocumentModel.Math;


/// <summary>
///   Lower-Limit Function.
/// </summary>
public partial class LimitLower
{
  
  /// <summary>
  ///   Lower Limit Properties.
  /// </summary>
  public LimitLowerProperties? LimitLowerProperties { get; set; }
  
  
  /// <summary>
  ///   Base.
  /// </summary>
  public Base? Base { get; set; }
  
  
  /// <summary>
  ///   Limit (Lower).
  /// </summary>
  public Limit? Limit { get; set; }
  
}
