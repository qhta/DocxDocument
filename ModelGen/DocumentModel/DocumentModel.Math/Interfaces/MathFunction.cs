namespace DocumentModel.Math;

/// <summary>
/// Function Apply Function.
/// </summary>
public partial interface MathFunction
{
  /// <summary>
  /// Function Properties.
  /// </summary>
  public DocumentModel.Math.FunctionProperties? FunctionProperties { get; set; }
  
  /// <summary>
  /// Function Name.
  /// </summary>
  public DocumentModel.Math.FunctionName? FunctionName { get; set; }
  
  /// <summary>
  /// Base (Argument).
  /// </summary>
  public DocumentModel.Math.Base? Base { get; set; }
  
}
