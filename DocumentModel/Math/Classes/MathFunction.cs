namespace DocumentModel.Math;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Function Apply Function.
/// </summary>
public class MathFunction: ModelElement, ICommonMathContent
{
  /// <summary>
  ///   Function Properties.
  /// </summary>
  public FunctionProperties? FunctionProperties { get; set; }

  /// <summary>
  ///   Function Name.
  /// </summary>
  public FunctionName? FunctionName { get; set; }

  /// <summary>
  ///   Base (Argument).
  /// </summary>
  public Base? Base { get; set; }
}