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
    get;
    set;
  }
  
  /// <summary>
  /// Lower limit (n-ary) .
  /// </summary>
  public SubArgument? SubArgument
  {
    get;
    set;
  }
  
  /// <summary>
  /// Upper limit (n-ary).
  /// </summary>
  public SuperArgument? SuperArgument
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
