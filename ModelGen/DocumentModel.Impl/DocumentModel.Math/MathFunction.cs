namespace DocumentModel.Math;

/// <summary>
/// Function Apply Function.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Math.IFunctionProperties))]
[ChildElementInfo(typeof(DocumentModel.Math.IFunctionName))]
[ChildElementInfo(typeof(DocumentModel.Math.IBase))]
public class MathFunction: IMathFunction
{
  /// <summary>
  /// Function Properties.
  /// </summary>
  public IFunctionProperties? FunctionProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Function Name.
  /// </summary>
  public IFunctionName? FunctionName
  {
    get;
    set;
  }
  
  /// <summary>
  /// Base (Argument).
  /// </summary>
  public IBase? Base
  {
    get;
    set;
  }
  
}
