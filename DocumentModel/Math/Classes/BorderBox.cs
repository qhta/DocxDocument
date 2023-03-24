namespace DocumentModel.Math;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Border-Box Function.
/// </summary>
public class BorderBox: ModelElement, ICommonMathElement
{
  /// <summary>
  ///   Border Box Properties.
  /// </summary>
  public BorderBoxProperties? BorderBoxProperties { get; set; }

  /// <summary>
  ///   Base.
  /// </summary>
  public Base? Base { get; set; }
}