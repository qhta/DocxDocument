namespace DocumentModel.Math;

/// <summary>
/// Lower-Limit Function.
/// </summary>
public class LimitLowerImpl: ModelElement<DocumentFormat.OpenXml.Math.LimitLower>, LimitLower
{
  /// <summary>
  /// Lower Limit Properties.
  /// </summary>
  public LimitLowerProperties? LimitLowerProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Base.
  /// </summary>
  public Base? Base
  {
    get;
    set;
  }
  
  /// <summary>
  /// Limit (Lower).
  /// </summary>
  public Limit? Limit
  {
    get;
    set;
  }
  
}
