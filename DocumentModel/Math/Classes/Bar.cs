namespace DocumentModel.Math;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Bar.
/// </summary>
public class Bar: ModelElement, ICommonMathElement
{
  /// <summary>
  ///   Bar Properties.
  /// </summary>
  public BarProperties? BarProperties { get; set; }

  /// <summary>
  ///   Base.
  /// </summary>
  public Base? Base { get; set; }
}