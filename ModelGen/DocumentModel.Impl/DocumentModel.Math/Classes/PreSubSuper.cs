namespace DocumentModel.Math;

/// <summary>
/// Pre-Sub-Superscript Function.
/// </summary>
public class PreSubSuperImpl: ModelElementImpl, PreSubSuper
{
  public DocumentFormat.OpenXml.Math.PreSubSuper? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.PreSubSuper?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Pre-Sub-Superscript Properties.
  /// </summary>
  public PreSubSuperProperties? PreSubSuperProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Subscript (Pre-Sub-Superscript).
  /// </summary>
  public SubArgument? SubArgument
  {
    get;
    set;
  }
  
  /// <summary>
  /// Superscript(Pre-Sub-Superscript function).
  /// </summary>
  public SuperArgument? SuperArgument
  {
    get;
    set;
  }
  
  /// <summary>
  /// Base.
  /// </summary>
  public Base? Base
  {
    get;
    set;
  }
  
}
