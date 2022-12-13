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
  
  public PreSubSuperImpl(): base() {}
  
  public PreSubSuperImpl(DocumentFormat.OpenXml.Math.PreSubSuper openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Pre-Sub-Superscript Properties.
  /// </summary>
  public DocumentModel.Math.PreSubSuperProperties? PreSubSuperProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Subscript (Pre-Sub-Superscript).
  /// </summary>
  public DocumentModel.Math.SubArgument? SubArgument
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Superscript(Pre-Sub-Superscript function).
  /// </summary>
  public DocumentModel.Math.SuperArgument? SuperArgument
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Base.
  /// </summary>
  public DocumentModel.Math.Base? Base
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
