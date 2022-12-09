namespace DocumentModel.Math;

/// <summary>
/// n-ary Operator Function.
/// </summary>
public class NaryImpl: ModelElementImpl, Nary
{
  public DocumentFormat.OpenXml.Math.Nary? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.Nary?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// n-ary Properties.
  /// </summary>
  public NaryProperties? NaryProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Lower limit (n-ary) .
  /// </summary>
  public SubArgument? SubArgument
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Upper limit (n-ary).
  /// </summary>
  public SuperArgument? SuperArgument
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
