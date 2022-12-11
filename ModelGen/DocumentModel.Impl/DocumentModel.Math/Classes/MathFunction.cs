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
  
  public MathFunctionImpl(): base() {}
  
  public MathFunctionImpl(DocumentFormat.OpenXml.Math.MathFunction openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Function Properties.
  /// </summary>
  public FunctionProperties? FunctionProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Function Name.
  /// </summary>
  public FunctionName? FunctionName
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Base (Argument).
  /// </summary>
  public Base? Base
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
