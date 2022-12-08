namespace DocumentModel.Math;

/// <summary>
/// Function Apply Function.
/// </summary>
public class MathFunctionImpl: ModelElementImpl, MathFunction
{
  public DocumentFormat.OpenXml.Math.MathFunction? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.MathFunction?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
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
