namespace DocumentModel.Math;

/// <summary>
/// Function Apply Function.
/// </summary>
public interface IMathFunction // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Function Properties.
  /// </summary>
  public IFunctionProperties? FunctionProperties { get ; set; }
  
  /// <summary>
  /// Function Name.
  /// </summary>
  public IFunctionName? FunctionName { get ; set; }
  
  /// <summary>
  /// Base (Argument).
  /// </summary>
  public IBase? Base { get ; set; }
  
}
