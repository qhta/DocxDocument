namespace DocumentModel.Math;

/// <summary>
/// Function Apply Function.
/// </summary>
public interface IMathFunction // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Function Properties.
  /// </summary>
  public DocumentModel.Math.IFunctionProperties? FunctionProperties { get ; set; }
  
  /// <summary>
  /// Function Name.
  /// </summary>
  public DocumentModel.Math.IFunctionName? FunctionName { get ; set; }
  
  /// <summary>
  /// Base (Argument).
  /// </summary>
  public DocumentModel.Math.IBase? Base { get ; set; }
  
}
