namespace DocumentModel.Math;

/// <summary>
/// Upper-Limit Function.
/// </summary>
public class LimitUpperImpl: ModelElement<DocumentFormat.OpenXml.Math.LimitUpper>, LimitUpper
{
  /// <summary>
  /// Upper Limit Properties.
  /// </summary>
  public LimitUpperProperties? LimitUpperProperties
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
  /// Limit (Upper).
  /// </summary>
  public Limit? Limit
  {
    get;
    set;
  }
  
}
