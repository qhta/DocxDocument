namespace DocumentModel.Math;


/// <summary>
///   Lower-Limit Function.
/// </summary>
public partial class LimitLower
{
  
  /// <summary>
  ///   Lower Limit Properties.
  /// </summary>
  public DocumentModel.Math.LimitLowerProperties? LimitLowerProperties { get; set; }
  
  
  /// <summary>
  ///   Base.
  /// </summary>
  public DocumentModel.Math.Base? Base { get; set; }
  
  
  /// <summary>
  ///   Limit (Lower).
  /// </summary>
  public DocumentModel.Math.Limit? Limit { get; set; }
  
}
