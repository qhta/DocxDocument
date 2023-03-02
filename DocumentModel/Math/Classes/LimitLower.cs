namespace DocumentModel.Math;

/// <summary>
///   Lower-Limit Function.
/// </summary>
public record LimitLower: DMW.ParagraphElement
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