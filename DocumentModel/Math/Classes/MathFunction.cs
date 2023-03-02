namespace DocumentModel.Math;

/// <summary>
///   Function Apply Function.
/// </summary>
public record MathFunction: DMW.ParagraphElement
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