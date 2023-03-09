namespace DocumentModel.Math;

/// <summary>
///   Function Apply Function.
/// </summary>
public class MathFunction: ICommonMathElement
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