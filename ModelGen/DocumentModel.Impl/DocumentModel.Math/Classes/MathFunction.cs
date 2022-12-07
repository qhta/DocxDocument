namespace DocumentModel.Math;

/// <summary>
/// Function Apply Function.
/// </summary>
public class MathFunctionImpl: ModelElement<DocumentFormat.OpenXml.Math.MathFunction>, MathFunction
{
  /// <summary>
  /// Function Properties.
  /// </summary>
  public FunctionProperties? FunctionProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Function Name.
  /// </summary>
  public FunctionName? FunctionName
  {
    get;
    set;
  }
  
  /// <summary>
  /// Base (Argument).
  /// </summary>
  public Base? Base
  {
    get;
    set;
  }
  
}
